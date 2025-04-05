# 🏦 Banking System App — Assignment (August 2022)

This project was created as part of an **Object-Oriented Programming (OOP)** and **Event-Driven Programming** module within the **FIT Software Development Programme**.

Built using:
- **C#**
- **Windows Forms (WinForms)**

---

## 📘 Project Overview

A Windows Forms application simulating a basic banking system, allowing customers to:

- Log in using an account number and PIN
- View their account balance
- Deposit or withdraw funds
- Generate log entries for both login attempts and transactions

This project places a strong focus on **event-driven programming**, particularly on using custom `EventArgs` and handling events for logins and transactions.

---

## ✅ Requirements

### 🔐 Login System

- Customers must enter their **account number** and **PIN** to log in.
- Successful login displays the customer's **current balance** (hardcoded).
- Failed and successful login attempts are **logged to a local file** with:
  - Account number
  - Date and time
  - Status (Success/Failure)
- Log entries are **appended** (not overwritten).
- A **custom `EventArgs` class** must be used to raise events for logging.
  
---

### 💰 Banking Operations

Once logged in, customers can:

- **Withdraw** or **deposit** funds
- See their **balance update** after each transaction
- These actions should **raise events**, triggering appropriate event handlers
- All transactions must be **logged to a separate file** with:
  - Account number
  - Date and time
  - Transaction type (Deposit/Withdrawal)
  - Transaction amount
  - New balance

---

## 🧱 Design Notes

- Use proper **OOP practices**:
  - Private fields
  - Public properties for encapsulation
- Create classes such as:
  - `Customer`  
  - `CustomerList` (with a hardcoded list of customers for validation)
- Validate login by checking credentials against the list of customers
- Implement **custom `EventArgs` classes** to carry event data
- Use event handler `object` parameters to access additional context

---

## 🖥️ UI Structure

- **Login Form**: Accepts account number and PIN
- **Account Form**: Shown upon successful login, displays balance and transaction options
- Closing the Account Form should return the user to the Login Form with cleared input fields

---

## ⚠️ Notes

> The main focus of this assignment is on the **use of events and custom event handlers**.  
> While general coding practices are encouraged, **error handling is not the primary concern** for this exercise.

---

## 📁 Example File Outputs

### Login Log

```
Account: 12345678 | 2022-08-10 14:32:11 | Login Successful
Account: 12345678 | 2022-08-10 14:34:00 | Login Failed
```

### Transaction Log

```
Account: 12345678 | 2022-08-10 14:35:12 | Deposit | Amount: 100 | Balance: 600
Account: 12345678 | 2022-08-10 14:37:45 | Withdrawal | Amount: 50 | Balance: 550
```

---



