# Комманды С#
https://pastebin.com/  !!!! можно быстро отправить свой код в виде ссылки

* dotnet new console - создает новый проект в папке
* dotnet run - запускает проект
* new Random().Next(min,max) - генерирует случайные числа

* ToLower() - возращает значение в нижнем регистре, т.е при вводе, при любом регистре слово будет опознано,
 пример - string username.ToLower() == "миша"
* Console.SetCursorPosition(x,y); - ставит точки на экране в заданных координатах
* Console.Clear(); - очищает экран


1. Интерполяция строк ($" text {}")
2. Try.Parse(str, out in number);
2.2 try{   }  catch{};
4. Console.Write(string.Join(",",array)); распечатывает массив без помощи цикла
5. array[0] = new Random().Next() + new Random().NextDouble();(таким образом можно задавать массив double. Просто Random выведет случайные числа от 0 до 1.0)
6. string str = Console.ReadLine();   // можно словить введеные в строке числа - главное знать как они разделяются(пробел, запятая и.т.д)
   string[] str2 = str.Split(" ");