set drive =E

xcopy /s /y "C:\Users\<user>\source\repos\MainApp\MainApp\bin\Release" "%drive %:\MainApp - Portable\MainApp\bin\Release\"
xcopy /s /y "C:\Users\<user>\source\repos\MainApp\Resources\Igdb" "%drive %:\MainApp - Portable\Resources\Igdb\"
xcopy /s /y "C:\Users\<user>\source\repos\MainApp\Resources\Imdb" "%drive %:\MainApp - Portable\Resources\Imdb\"
xcopy /s /y "C:\Users\<user>\source\repos\MainApp\Resources\Stats" "%drive %:\MainApp - Portable\Resources\Stats\"
xcopy /s /y "C:\Users\<user>\source\repos\MainApp\Resources\Following.json" "%drive %:\MainApp - Portable\Resources\Following.json*"
xcopy /s /y "C:\Users\<user>\source\repos\MainApp\Resources\JsonData" "%drive %:\MainApp - Portable\Resources\JsonData\"