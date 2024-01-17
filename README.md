# DemoBankingSystem 
**DemoBankingSystem** is a slightly reworked version of the [BankSystem](https://github.com/banksystembg/BankSystem) open-source web project where users can create bank accounts, transfer money, create payment cards, pay with them or directly through their account, etc.
It supports connecting multiple banks together through a Central Banking API. This allows money to be securely transferred between **separate instances of the Retail Banking system**.

The key solutions are:
- CentralBank, hosting the Central Banking API allowing inter-bank transactions
- RetailBank, which will be a generalised version of `BankSystem` easy to run on multiple hosting environments
- DownstreamEnvironment, containing the DemoShop connected to a Retail Bank and the RSA Key Generator

Features to be added will be a full CI/CD orchestration as well as Infrastructure as Code to deploy the solutions end-to-end on Azure.