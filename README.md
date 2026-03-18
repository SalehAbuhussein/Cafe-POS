# ☕ Cafe POS Management System

A desktop **Point of Sale (POS)** application built with **C# and Windows Forms** to manage cafe operations efficiently.

---

## 📌 Features

### 🔐 Authentication & Users

* User login system
* Role-based access control (e.g., Owner, Staff)
* Edit user information
* Change password

---

### 🧾 Orders & Sales

* Create and manage orders
* Track total daily sales
* Track total number of orders

---

### 💸 Refund System

* Full refund support
* Partial refund support
* Track total refunded cash (daily)

---

### 📦 Inventory Management

* Restock products
* Manage product quantities

---

### 📊 Dashboard

* View today's:

  * Total sales
  * Order count
  * Refund amount

---

## 🗄️ Database Schema

The following diagram shows the database design of the system:

<img width="1311" height="819" alt="Cafe POS drawio" src="https://github.com/user-attachments/assets/2d1b0280-0c22-4f7c-a11e-d0eb85d4f831" />

* Users and roles are connected through a many-to-many relationship.
* Orders contain multiple order items.
* Refunds support both full and partial refunds.
* Products are linked to categories and support restocking.

---

## 🛠️ Technologies Used

* **C#**
* **.NET Framework (WinForms)**
* **SQL Server**
* **ADO.NET**

---

## 🏗️ System Overview

The system is designed to handle core cafe operations:

* Orders and order items
* Refund tracking
* User management with roles
* Product inventory

---

## 🚀 Getting Started

### Prerequisites

* Visual Studio
* SQL Server

### Setup

1. Clone the repository
2. Restore the database (https://drive.google.com/file/d/17Hl-_VUW9O9FxEDsHEdJlxAU7oW1npsD/view?usp=sharing).
3. Update connection string in the project
4. Run the application

---

## 🔑 Roles & Permissions

* **Owner**

  * Full access to system
* **Staff**

  * Limited access (orders, basic operations)

## 👨‍💻 Author

Saleh Abuhussein

---
