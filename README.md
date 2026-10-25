# Система учета заявок пользователей (Service Desk App)

Модульное веб-приложение на C# (ASP.NET Core Web API) для автоматизации регистрации и контроля исполнения обращений пользователей в службу технической поддержки.

## Стек технологий
- Платформа: .NET 8 / C#
- Web API: ASP.NET Core Controllers
- Документация API: Swagger UI / OpenAPI
- Хранение данных: Локальные JSON-файлы (System.Text.Json)
- Frontend: HTML5, CSS3, JavaScript (Fetch API)

## Архитектура решения
Проект построен по слоистой модели:
- `Models` — классы сущностей и перечислений;
- `Repositories` — инкапсуляция работы с JSON (паттерн Repository);
- `Services` — бизнес-логика и правила валидации;
- `Controllers` — конечные точки REST API;
- `wwwroot` — клиентский веб-интерфейс (SPA).

## Инструкция по запуску
1. Склонировать репозиторий:
   git clone https://github.com/keradorax228/RequestTrackerApp.git
2. Перейти в директорию проекта:
   cd RequestTrackerApp
3. Собрать и запустить проект:
   dotnet run
4. Открыть в браузере:
   - Веб-интерфейс: http://localhost:5000/
   - Документация Swagger API: http://localhost:5000/swagger
