# 🎬 Serenity Movie Tutorial App

A **Movie Management web application** built using the **Serenity Application Framework**. This project follows the official Serenity Movie Tutorial and demonstrates how to build a clean, scalable, enterprise-style CRUD application using ASP.NET Core and TypeScript.

---

## 📌 Overview

The Serenity Movie Tutorial App is a learning-oriented project designed to help developers understand the fundamentals of the Serenity Framework. It showcases how Serenity simplifies building data-driven business applications with minimal boilerplate and strong architectural patterns.

This application allows users to manage movies with full **Create, Read, Update, and Delete (CRUD)** functionality through a modern web interface.

---

## 🚀 Features

* Movie CRUD operations
* Entity Grid with paging, sorting, and filtering
* Quick Search functionality
* Dialog-based data entry
* Role-based authorization & permissions
* Clean layered architecture
* Reusable service & repository patterns

---

## 🛠 Tech Stack

* **Backend:** ASP.NET Core (C#)
* **Frontend:** TypeScript, Serenity UI
* **Framework:** Serenity Application Framework
* **Database:** SQL Server
* **IDE:** Visual Studio 2019 / 2022

---

## 📂 Project Structure

```
MovieTutorial
│
├── MovieTutorial.Web
│   ├── Modules
│   │   └── MovieDB
│   │       ├── Movie
│   │       │   ├── MovieRow.cs
│   │       │   ├── MovieRepository.cs
│   │       │   ├── MovieEndpoint.cs
│   │       │   ├── MovieDialog.tsx
│   │       │   └── MovieGrid.tsx
│   ├── Migrations
│   ├── wwwroot
│   └── appsettings.json
│
└── MovieTutorial.sln


## ⚙️ Prerequisites

Before running the application, ensure you have the following installed:

* .NET SDK (6.0 or later)
* Visual Studio 2019 or 2022
* SQL Server / SQL Server Express
* Node.js (LTS recommended)

---

## ▶️ Getting Started

### 1️⃣ Clone the Repository

```bash
git clone https://github.com/your-username/serenity-movie-tutorial.git
```

### 2️⃣ Open the Solution

Open `MovieTutorial.sln` in Visual Studio.

### 3️⃣ Configure Database

Update the connection string in `appsettings.json`:

```json
"Default": "Server=.;Database=MovieTutorial;Trusted_Connection=True;"
```

### 4️⃣ Run Migrations

From Visual Studio:

* Open **Package Manager Console**
* Run:

```powershell
Update-Database
```

### 5️⃣ Run the Application

Press **F5** or click **Run** in Visual Studio.

---

## 🔐 Default Login

```
Username: admin
Password: serenity
```

---

## 📖 Learning Outcomes

By working with this project, I will learn:

* Serenity entity and row mapping
* Grid and dialog customization
* Service endpoint patterns
* Permission handling
* TypeScript integration with backend services




## 🤝 Contributing

Contributions are welcome! Feel free to fork the repository and submit pull requests.

---

## 📜 License

This project is for educational purposes and follows the Serenity framework licensing terms.

---
