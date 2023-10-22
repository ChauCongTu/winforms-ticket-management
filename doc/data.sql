CREATE DATABASE airplane_ticket_management;
USE airplane_ticket_management;

-- Tạo bảng
CREATE TABLE airlines (
    airline_id INT PRIMARY KEY IDENTITY(1,1),
    airline_name NVARCHAR(255) NOT NULL
);

CREATE TABLE airports (
    airport_id INT PRIMARY KEY IDENTITY(1,1),
    airport_name NVARCHAR(255) NOT NULL,
    coordinates NVARCHAR(255) NOT NULL,
    address NVARCHAR(255) NOT NULL,
    city NVARCHAR(255) NOT NULL,
    country NVARCHAR(255) NOT NULL
);

CREATE TABLE airplanes (
    airplane_id INT PRIMARY KEY IDENTITY(1,1),
    airplane_type NVARCHAR(255) NOT NULL,
    description NVARCHAR(255) NOT NULL,
    airplane_number NVARCHAR(255) NOT NULL,
    number_of_seats INT,
    airline_id INT FOREIGN KEY REFERENCES airlines(airline_id)
);

CREATE TABLE ticket_classes (
    class_id INT PRIMARY KEY IDENTITY(1,1),
    class_type NVARCHAR(255) NOT NULL
);

CREATE TABLE users (
    user_id INT PRIMARY KEY IDENTITY(1,1),
    user_name NVARCHAR(255) NOT NULL,
    email_address NVARCHAR(255) NOT NULL,
    password NVARCHAR(255) NOT NULL,
    role NVARCHAR(50) NOT NULL,
    gender NVARCHAR(50) NOT NULL,
    phone_number NVARCHAR(15) NOT NULL,
    address NVARCHAR(255) NOT NULL,
    status NVARCHAR(50) DEFAULT 'active' CHECK (status IN ('active', 'inactive'))
);

CREATE TABLE customers (
    customer_id INT PRIMARY KEY IDENTITY(1,1),
    customer_name NVARCHAR(255) NOT NULL,
    phone_number NVARCHAR(15) NOT NULL,
    email_address NVARCHAR(255) NOT NULL,
    id_number NVARCHAR(20) NOT NULL,
    gender NVARCHAR(50) NOT NULL,
    date_of_birth DATE
);

CREATE TABLE flights (
    flight_id INT PRIMARY KEY IDENTITY(1,1),
    departure_point NVARCHAR(255) NOT NULL,
    destination NVARCHAR(255) NOT NULL,
    departure_airport INT FOREIGN KEY REFERENCES airports(airport_id),
    destination_airport INT FOREIGN KEY REFERENCES airports(airport_id),
    departure_time DATETIME,
    arrival_time DATETIME,
    flight_date DATE,
    total_tickets INT DEFAULT 0,
    remaining_tickets INT,
    transits INT DEFAULT 0,
    aircraft_id INT FOREIGN KEY REFERENCES airplanes(airplane_id),
    status NVARCHAR(50) DEFAULT 'active' CHECK (status IN ('active', 'delay', 'cancel'))
);

CREATE TABLE tickets (
    ticket_id INT PRIMARY KEY IDENTITY(1,1),
    flight_id INT FOREIGN KEY REFERENCES flights(flight_id),
    ticket_class int FOREIGN KEY REFERENCES ticket_classes(class_id),
    price_vnd INT,
    price_usd FLOAT,
    seat_numb NVARCHAR(255) NULL DEFAULT '0',
    CONSTRAINT CHK_seat_numb CHECK (seat_numb IS NULL OR seat_numb <> '')
);

CREATE TABLE transactions (
    transaction_id INT PRIMARY KEY IDENTITY(1,1),
    booking_code NVARCHAR(255) NOT NULL,
    ticket_id INT FOREIGN KEY REFERENCES tickets(ticket_id),
    customer_id INT FOREIGN KEY REFERENCES customers(customer_id),
    note NTEXT,
    booking_date DATETIME null,
    performed_by INT FOREIGN KEY REFERENCES users(user_id)
);

CREATE TABLE transits (
    transit_id INT PRIMARY KEY IDENTITY(1,1),
    transit_airport_id INT FOREIGN KEY REFERENCES airports(airport_id),
    flight_id INT FOREIGN KEY REFERENCES flights(flight_id)
);

ALTER TABLE customers
ADD CONSTRAINT UQ_id_number UNIQUE (id_number);



-- Tạo trigger
-- Thiết lập thời gian đặt vé
CREATE TRIGGER SetBookingDateOnInsert
ON transactions
AFTER INSERT
AS
BEGIN
    UPDATE transactions
    SET booking_date = GETDATE()
    FROM transactions
    INNER JOIN inserted ON transactions.transaction_id = inserted.transaction_id;
END;

-- Thiết lập tự động tính đơn giá theo USD
CREATE TRIGGER CalculatePriceUSD
ON tickets
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE tickets
    SET price_usd = ISNULL(inserted.price_vnd, 0) / 24000
    FROM inserted
    WHERE tickets.ticket_id = inserted.ticket_id;
END;

-- Cập nhật lại remain ticket khi có transaction được tạo
CREATE TRIGGER UpdateRemainingTickets
ON transactions
AFTER INSERT
AS
BEGIN
    UPDATE flights
    SET remaining_tickets = remaining_tickets - 1
    FROM flights
    INNER JOIN tickets ON flights.flight_id = tickets.flight_id
    INNER JOIN inserted ON tickets.ticket_id = inserted.ticket_id;
END;

-- Cập nhật lại số lượng transits trong flight
CREATE TRIGGER UpdateTransitsCount
ON transits
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    UPDATE flights
    SET transits = (
        SELECT COUNT(*)
        FROM transits
        WHERE transits.flight_id = flights.flight_id
    )
    FROM flights
    INNER JOIN (
        SELECT DISTINCT flight_id
        FROM inserted
        UNION ALL
        SELECT DISTINCT flight_id
        FROM deleted
    ) AS changes ON flights.flight_id = changes.flight_id;
END;

-- Chèn dữ liệu cho bảng airlines
INSERT INTO airlines (airline_name)
VALUES 
    (N'Vietnam Airlines'),
    (N'Bamboo Airways'),
    (N'VietJet Air');

-- Chèn dữ liệu cho bảng airports
INSERT INTO airports (airport_name, coordinates, address, city, country)
VALUES 
    (N'Tan Son Nhat International Airport', N'10.8184° N, 106.6518° E', N'Trường Sơn, Tân Bình', N'Ho Chi Minh City', N'Vietnam'),
    (N'Noi Bai International Airport', N'21.2190° N, 105.8031° E', N'Phú Minh, Sóc Sơn', N'Hanoi', N'Vietnam'),
    (N'Phu Cat Airport', N'16.0435° N, 108.1985° E', N'Phù Cát', N'Binh Dinh', N'Vietnam'),
    (N'Da Nang International Airport', N'16.0435° N, 108.1985° E', N'Phường Hoà Thuận Tây, Quận Hải Châu', N'Da Nang', N'Vietnam');

-- Chèn dữ liệu cho bảng airplanes
INSERT INTO airplanes (airplane_type, description, airplane_number, number_of_seats, airline_id)
VALUES 
    (N'Boeing 777', N'Wide-body jet airliner', N'VN-A818', 300, 1),
    (N'Airbus A321', N'Narrow-body jet airliner', N'VN-A688', 200, 2),
    (N'Airbus A320', N'Narrow-body jet airliner', N'VN-A622', 180, 3);

-- Chèn dữ liệu cho bảng ticket_classes
INSERT INTO ticket_classes (class_type)
VALUES 
    (N'Economy'),
    (N'Business'),
    (N'First Class');

-- Chèn dữ liệu cho bảng users
INSERT INTO users (user_name, email_address, password, role, gender, phone_number, address, status)
VALUES 
    (N'admin', N'admin@example.com', N'password123', N'admin', N'Male', N'123456789', N'123 Main St, Ho Chi Minh City', N'active'),
    (N'user1', N'user1@example.com', N'password456', N'user', N'Female', N'987654321', N'456 Oak St, Hanoi', N'active'),
    (N'user2', N'user2@example.com', N'password789', N'user', N'Male', N'456789123', N'789 Pine St, Da Nang', N'active');

-- Chèn dữ liệu cho bảng customers
INSERT INTO customers (customer_name, phone_number, email_address, id_number, gender, date_of_birth)
VALUES 
    (N'Nguyen Van A', N'0987654321', N'nguyenvana@example.com', N'123456789', N'Male', '1990-01-15'),
    (N'Tran Thi B', N'0123456789', N'tranthib@example.com', N'987654321', N'Female', '1985-05-20'),
    (N'Le Van C', N'0912345678', N'levanc@example.com', N'456789123', N'Male', '2000-10-10');

-- Chèn dữ liệu cho bảng flights
INSERT INTO flights (departure_point, destination, departure_airport, destination_airport, departure_time, arrival_time, flight_date, total_tickets, remaining_tickets, aircraft_id, status)
VALUES 
    (N'Ho Chi Minh City', N'Hanoi', 1, 2, '2023-10-25 08:00:00', '2023-10-25 10:30:00', '2023-10-25', 200, 150, 1, N'active'),
    (N'Hanoi', N'Da Nang', 2, 3, '2023-10-26 12:00:00', '2023-10-26 13:30:00', '2023-10-26', 150, 120, 2, N'active'),
    (N'Da Nang', N'Ho Chi Minh City', 3, 1, '2023-10-27 14:00:00', '2023-10-27 16:00:00', '2023-10-27', 180, 170, 3, N'active');

-- Chèn dữ liệu cho bảng tickets
INSERT INTO tickets (flight_id, ticket_class, price_vnd, price_usd, seat_numb)
VALUES 
    (1, 1, 1500000, NULL, N'12A'),
    (1, 2, 3000000, NULL, N'7B'),
    (2, 1, 1200000, NULL, N'8C'),
    (2, 2, 2500000, NULL, N'5D'),
    (3, 1, 1800000, NULL, N'15E'),
    (3, 2, 3200000, NULL, N'3F');

-- Chèn dữ liệu cho bảng transits
INSERT INTO transits (transit_airport_id, flight_id)
VALUES 
    (2, 1),
    (3, 2),
    (1, 3);
