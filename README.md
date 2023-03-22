# Описание работы программы
1. Очистка окна терминала;
2. Запрос на ввод текста;
3. Чтение текста из строки и сохранение в **text**;
4. Запрос на ввод числа поиска элементов;
5. Чтение числа из строки и сохранение в **n**;
6. Вызов метода *Recognition* и передачи в него **text**;
7. Вызов метода *Scan* и передачи в него результат из метода *Recognition* и числа **n**;
8. Печать результата метода *Scan*.

## Описание метода *Recognition*
1. Прием текста в метод;
2. Запись слов из текста в массив (*Слова разделяются пробелом*);
3. Возврат массива всех слов из текста.

## Описание метода *Scan*
1. Прием массива слов и длинны слова "**n**" для поиска подходящих элементов;
2. Создаем новый *временный* массив для запоминания позиции подходящих слов из входного массива.
3. Проверка **каждого** слова из *входного* массива на условие поиска. (Найти все слова чья длинна меньше или ровна "**n**");
4. Запоминая позиций подходящих слов во *временном* массиве;
5. Создание *конечного* массива;
6. Переписывание слов в *конечный* массив из *входного* массива чей индекс хранится во *временном* массиве;
7. Возврат массива слов подошедших поиску.