# Mzansi Payroll System

#  Project Overview
The **Mzansi Payroll System** is a Windows Forms application developed for the PM‑04 Practical Module.  
It allows users to capture contractor payroll details and automatically calculate Gross Pay, UIF, Membership Fee, PAYE, and Net Pay.



# Features
Input validation:
  Empty name blocked
  Hours must be numeric and non‑negative
  Dependents must be numeric and between 0–10
  Payroll calculations with Rand (R)
  Buttons
  Calculate performs payroll calculations
    Reset clears all fields
    Exit closes the application
    Unit Testing with MSTest for all payroll formulas


 Testing
Unit Testing Gross Pay, UIF, Membership Fee, PAYE, Net Pay  
  Integration TestingcEnsures UI correctly integrates with `PayrollCalculator` class  
  System Testing End‑to‑end workflow validation (input → calculation → output → reset/exit)  
  Error Handling and Validation Testing Empty, non‑numeric, negative, and out‑of‑range inputs  
  Retesting and Regression Testing Confirmed fixes and ensured no new defects introduced  


# Evidence
Screenshots included in the submission PDF:
GUI outputs (Calculate, Reset, Exit)
Validation error messages
Test Explorer results with green checkmarks
Red box logs showing expected vs actual values



# How to Run
1. Clone the repository:
   bash
   git clone https://github.com/AsavelaLose/MzansiPayrollSystem.git
