# 📅 Appointment Tracking API

A simple .NET Web API project for managing appointments. This API allows users to **create, read, update, and delete (CRUD)** appointments using an **in-memory list** (no database required). 🚀

## 🌟 Features
- ✅ **Create, Read, Update, and Delete (CRUD) Appointments**
- 🔄 **Uses GUID for Unique Identifiers**
- 💾 **In-Memory Storage (No Database Required)**
- 📜 **RESTful API Design**
- 🛠 **Testable via Swagger & Postman**

## 🏗 Project Structure
📂 **AppointmentTrackingAPI**  
┣ 📂 **Controllers**  
┃ ┗ 📄 `AppointmentsController.cs` → Manages API requests  
┣ 📂 **Models**  
┃ ┗ 📄 `Appointment.cs` → Defines appointment properties  
┣ 📂 **Services**  
┃ ┗ 📄 `AppointmentService.cs` → Handles appointment logic  
┣ 📂 **Data**  
┃ ┗ 📄 `DummyData.cs` → Holds in-memory appointment data  
┣ 📄 `Program.cs` → Entry point of the API  
┣ 📄 `appsettings.json` → Configuration file  

## 🚀 Getting Started
### 1️⃣ Clone the Repository
```sh
git clone https://github.com/EfsanNart/simple-appointment-tracking-api.git
cd AppointmentTrackingAPI
```

### 2️⃣ Install Dependencies
Ensure you have .NET installed. Then run:
```sh
dotnet restore
```

### 3️⃣ Run the API
```sh
dotnet run
```

### 4️⃣ Open in Swagger
Once running, open your browser and go to:
```
https://localhost:5001/swagger/index.html
```

## 🔥 API Endpoints
| Method | Endpoint | Description |
|--------|----------|-------------|
| `GET` | `/api/appointments` | Get all appointments |
| `GET` | `/api/appointments/{id}` | Get a specific appointment |
| `POST` | `/api/appointments` | Create a new appointment |
| `PUT` | `/api/appointments/{id}` | Update an existing appointment |
| `DELETE` | `/api/appointments/{id}` | Delete an appointment |

## 🛠 Technologies Used
- 🌐 **.NET Web API**
- 📌 **C#**
- 🏗 **MVC Architecture**
- 🔧 **Swagger for API Testing**

## 🤝 Contributing
Contributions are welcome! Feel free to fork this repo and submit a PR.

## 📜 License
This project is licensed under the MIT License.

---
🚀 **Happy Coding!**

