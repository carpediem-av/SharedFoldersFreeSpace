Иногда использование сетевых папок, подключенных как обычный диск, неудобно. Например, если файловый сервер или NAS часто бывает выключен, то Проводник Windows может время от времени заметно тормозить. Или может вам просто не хочется видеть в нем кучу «лишних» дисков.

Но в этом случае, открыв сетевую папку по пути вида "\\\\ПК\папка", мы не сможем увидеть, сколько свободного пространства в ней присутствует. Конечно, остается вариант с RDP и веб-интерфейсом NAS, но вряд ли такой способ покажется удобным в повседневной работе.

Для себя я написал маленькую программу, которая выводит список всех сетевых папок на сервере и показывает напротив них число свободных гигабайт. На рабочий стол я вывел ярлык, дописав в поле Объект через пробел после имени программы сетевое имя сервера (можно и IP).

Программа требует для запуска Microsoft .NET Desktop Runtime 6.0 (https://dotnet.microsoft.com/en-us/download/dotnet/6.0).
