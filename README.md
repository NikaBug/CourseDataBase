# CourseDataBase
CourseDataBase — курсовий проєкт, метою якого є розробка настільного додатку Windows для роботи з реляційною базою даних онлайн-магазину товарів.
## Table of Contents
* [General Info](#general-information)
* [Technologies Used](#technologies-used)
* [Features](#features)
* [Screenshots](#screenshots)
* [Project Status](#project-status)
<!-- * [License](#license) -->
## General Information
- ER (Entity-Relationship) модель бази даних
![ER screenshot](./Screenshots/ER_diagr21.jpg)
- Діаграма бази даних із середовища SQL Server Management Studio
![DatabaseDiagram screenshot](./Screenshots/DbDiagram_MSSMS.png)

## Technologies Used
- .NET Framework - version 4.7.2
- Microsoft.ReportingServices.ReportViewerControl.Winforms - version 150.1586.0
- Microsoft.SqlServer.Types - version 14.0.314.76

## Features
CourseDataBase має наступні функції:
- відображення та редагування (додавання, видалення та збереження) для рядків даних кожної таблиці;
- створення звітної інформації (у вигляді таблиці та оформленого звіту).

## Screenshots
<!-- ![Example screenshot](./img/screenshot.png) -->
- Головна форма — меню з вибором таблиць бази даних.
![MainForm screenshot](./Screenshots/main-form.png)
- Форма таблиці товарів — містить таблицю з даними, панель керування та кнопку для створення звітної інформації.
![GoodsForm screenshot](./Screenshots/goods-form.png)
- Форма звіту для товарів — містить таблицю-звіт та спеціальний звіт.
![ReportGoodsForm screenshot](./Screenshots/report-goods-form.png)
- Звіт для таблиці товарів, експортований у форматі excel.
![ReportGFExcel screenshot](./Screenshots/report-gf-excel.png)

## Project Status
Проєкт завершено 25 грудня 2023 року.
