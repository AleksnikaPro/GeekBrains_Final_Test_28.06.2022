# Итоговая проверочная работа. 

## Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

### Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"];
["1234", "1567", "-2", "computer science"] -> ["-2"];
["Russia", "Denmark", "Kazan"] -> [];

## Решение задачи:
1. Сначала задаем строковый массив на старте выполнения алгоритма. 
2. На следующем этапе в теле метода SelectWordInArray в первом цикле элементы исходного массива проходят проверку на условие выборки: длина строки массива должна быть либо меньше либо равна 3 символам. Таким образом программа определяет количество элементов массива, которое соответствует условию проверки. Данное количество элементов будет использовано в качестве длины нового массива, который будет создан в теле метода SelectWordInArray. Далее во втором цикле программа заполняет новый массив элементами (из трех или менее символов) из исходного массива.
3. Выводим на консоль исходный массив и новый массив при помощи метода PrintArray для наглядного сравнения.

### Блок-схема находится в файле *flowchart.png*
### Код программы находится в файле *Program.cs*


### Решила задачу студентка курса "Разработчик" *Попова А.Н.*