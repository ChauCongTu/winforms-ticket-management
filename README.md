## Airline Ticket Management System

<p style="text-align:center">
  <img src="https://cdn.discordapp.com/attachments/1100753623849377835/1164542647088717854/360861.png" width="100px">
</p>

### Introduction

The **Airline Ticket Management System** is a comprehensive application tailored for travel agents and agencies to streamline the process of managing airline ticket bookings, customer information, invoices, and generating insightful reports. Developed using C# and WinForms, this system provides a user-friendly interface that empowers agents to efficiently handle their day-to-day operations in the fast-paced world of air travel.

### Key Features

- **User-Friendly Interface**: The intuitive interface ensures that agents can navigate the system effortlessly, making it accessible for both novice and experienced users.

- **Booking Management**: Agents can effortlessly browse and book flights for their clients, with a detailed view of available flights including destinations, timings, and airline information.

- **Customer Relationship Management (CRM)**: The system enables agents to maintain a comprehensive database of customers, allowing them to efficiently retrieve and update customer information.

- **Invoice Generation**: Streamlined invoice generation ensures that agents can promptly provide their clients with detailed billing information, enhancing transparency in transactions.

- **Statistical Reports**: The system boasts a powerful reporting module that provides agents with valuable insights into their booking trends, revenue generation, and other critical metrics, allowing for informed business decisions.

- **Multi-User Support**: Multiple agents can use the system simultaneously, ensuring seamless collaboration within the agency.


### Contributor

- **Chau Que Nhon** - [GitHub Profile](https://github.com/chaucongtu)
- **Luu Nhat Thanh**
- **Le Thanh Nhan**
- **Nguyen Minh Phuc** 

### Installation Guide

1. Clone the repository:

```
git clone https://github.com/ChauCongTu/winforms-ticket-management.git
```


2. Open the solution file `AirlineTicketManagement.sln` in Visual Studio.

3. **Import Initial Data:**

- In your SQL Server Management Studio, create a new database for the application.
- Locate the `data.sql` file in the repository and run it in the newly created database to populate it with initial data.

4. Create file DBConnection.cs in DAO folder with code:
```
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Sunny.UI.Demo.DAO
{
    public class DBConnection
    {
        public string _strConn = "Connection String";
        public DBConnection()
        {

        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(_strConn);
        }
    }
}
```

5. Build and run the application from Visual Studio.

### Getting Started

1. Log in to the application using your agent username and password.

2. Start managing airline tickets, customers, invoices, and generate reports from the user interface.

### Contribution

We welcome contributions from the community. If you have any ideas or improvements, please create a pull request or open an issue so that we can discuss and collaborate to make the application better.

### Issue Reporting

If you discover any issues or have improvement requests, please open an issue on GitHub.

---

