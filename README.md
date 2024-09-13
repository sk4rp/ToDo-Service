# To-Do List Microservice

## Описание проекта

Этот проект представляет собой микросервис для управления задачами (To-Do List), реализованный с использованием технологий .NET. Проект включает в себя реализацию CRUD операций (Создание, Чтение, Обновление и Удаление задач) с использованием ASP.NET Core, Entity Framework Core и паттернов проектирования для организации чистой архитектуры.

## Технологии

- **ASP.NET Core**: Для создания RESTful API.
- **Entity Framework Core**: Для взаимодействия с базой данных.
- **MediatR**: Для управления командами и запросами с использованием паттерна "Mediator".
- **Dependency Injection**: Для облегчения тестирования и поддержки.
- **Swagger (OpenAPI)**: Для автоматической генерации документации API.

## Архитектура

Проект разделен на следующие слои:

1. **Presentation Layer (Controllers)**: Обрабатывает HTTP-запросы и возвращает HTTP-ответы.
2. **Business Logic Layer (Services)**: Содержит бизнес-логику приложения.
3. **Data Access Layer (Repositories)**: Выполняет операции доступа к данным и взаимодействует с базой данных.

### Зависимости между слоями

- **Controllers** зависят от **Services**.
- **Services** зависят от **Repositories**.
- **Repositories** взаимодействуют с **Entity Framework Core**.

## Установка и запуск

### Требования

- [.NET 6.0 или выше](https://dotnet.microsoft.com/download/dotnet)
- [Entity Framework Core](https://learn.microsoft.com/ru-ru/ef/core/)
- [MediatR](https://github.com/jbogard/MediatR)
- [Swagger](https://swagger.io/tools/swagger-ui/)

### Шаги для запуска

1. Клонируйте репозиторий:
    ```bash
    git clone https://github.com/yourusername/todo-list-microservice.git
    cd todo-list-microservice
    ```

2. Установите зависимости и выполните миграции базы данных:
    ```bash
    dotnet restore
    dotnet ef database update
    ```

3. Запустите приложение:
    ```bash
    dotnet run
    ```

4. Откройте браузер и перейдите по адресу [http://localhost:5000/swagger](http://localhost:5000/swagger) для доступа к документации API.

## Эндпоинты API

- **POST /api/tasks**: Создание новой задачи.
- **GET /api/tasks**: Получение списка задач.
- **GET /api/tasks/{id}**: Получение задачи по идентификатору.
- **PUT /api/tasks/{id}**: Обновление задачи.
- **DELETE /api/tasks/{id}**: Удаление задачи.

## Тестирование

Для запуска тестов используйте xUnit:

```bash
dotnet test
