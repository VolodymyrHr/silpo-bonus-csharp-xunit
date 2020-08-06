## Запуск проекта 
1. Сделать форк репозитория. Для своего репо использовать имя `silpo-bonus`. 
2. Выполнить команды, заменив `<your-github-username>` на… имя вашего пользователя в GitHub
   ```bash
   git clone https://github.com/<your-github-username>/silpo-bonus
   cd silpo-bonus
   dotnet restore
   dotnet test
   ```
3. Открыть VSCode `code .` 
4. Установить рекомендованные плагины для VSCode
   ```
   "spencer-farley.xunitsnippets",
   "formulahendry.dotnet-test-explorer"
   ```
5. После установки `formulahendry.dotnet-test-explorer` тесты можно запускать в сайдбаре  Test (c иконкой колбы)

## Задание
Реализовать подсчет балов Silpo, как [описано в задании](https://interlink-incamp.gitbook.io/s18/w1/oop/silpo-bonus).
