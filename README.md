# 🔐 AccountProvider – OAuth-Style Authentication Service (Azure Hosted)

**AccountProvider** is a custom-built user authentication and authorization service developed with **ASP.NET Core**.  
It acts as a lightweight **OAuth-style identity provider** that can be integrated across multiple web applications.

🚀 This project was hosted on **Microsoft Azure** during my time at [EC Utbildning – Webbutvecklare inom .NET YH-program].

---

## 🎯 Purpose

To create a centralized login system that allows different front-end projects to authenticate users through a shared back-end.  
This architecture improves security, consistency, and scalability.

Use cases include:
- Reusable login provider for portfolio sites or internal apps.
- Practical experience in secure user handling with token-based authentication.
- Demonstration of real-world fullstack deployment with .NET & Azure.

---

## 🧰 Tech Stack

- **C# / .NET 6**
- **ASP.NET Core MVC**
- **Entity Framework Core**
- **Identity + Role-based Access**
- **Azure App Service**
- **SQL Server (Azure)**
- **RESTful APIs**

---

## 🔒 Features

- User registration with hashed password storage.
- Secure login endpoint with role claims.
- Token-based access (JWT or session-based depending on setup).
- Database-first or code-first Entity Framework approach.
- Admin/user role support.

---

## 🌐 Live Deployment

✅ **Hosted on Microsoft Azure App Service**  
URL (demo): `https://your-accountprovider.azurewebsites.net` *(replace if private or add screenshot if confidential)*

You can test it locally or integrate with your front-end by calling the `/api/account/login` and `/api/account/register` endpoints.

---

## 📦 Project Structure

```

AccountProvider/
├── Controllers/
│   └── AccountController.cs
├── Data/
│   └── ApplicationDbContext.cs
├── Models/
│   └── User.cs
│   └── RegisterViewModel.cs
│   └── LoginViewModel.cs
├── Views/
│   └── Account/
├── wwwroot/
├── Program.cs
├── Startup.cs
└── appsettings.json

````

---

## 🧪 Getting Started Locally

1. Clone the repo:
   ```bash
   git clone https://github.com/your-username/AccountProvider.git
   cd AccountProvider
````

2. Set your local database connection string in `appsettings.json`.

3. Run:

   ```bash
   dotnet ef database update
   dotnet run
   ```

---

## 📘 What I Learned

* Authentication architecture and separation of concerns.
* Azure deployment pipeline.
* Handling sensitive data securely in production environments.
* Using Identity with Entity Framework in a custom way.

---

## 📄 License

This project was created as part of a school assignment at EC Utbildning.
It is open for **educational and demonstration purposes**.
Feel free to fork, clone, or extend it for your own portfolio.

---

👤 Created by **Nour Altinawi** –
.NET Fullstack Developer & 3D Visual Designer
[LinkedIn](https://www.linkedin.com/in/nour-tinawi) • [GitHub](https://github.com/Norman-Deen)
