# TestAutoApi
### Несколько слов о проекте
* Платформа: .netcore 3.1
* Фреймворк : ASP.net core MVC
* ORM: Entity Framework Core
* Database: postgreSQL    
 для localDb от MS SQL поменять Conntection string в appsetings.json на    
 "Data Source=(localdb)\\mssqllocaldb;  Initial Catalog=TestDatabase1;  Trusted_Connection=True;"
* Для удобства, подключил Swagger
* Логика работы с базой данных основана на паттерне IRepository
* Для инциализации базы данных в консоли менеджера пакетов прописать: Update-Database
