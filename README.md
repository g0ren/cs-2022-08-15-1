# Домашнее Задание 5

На уроках мы:

*    Узнали как работает класс String в C# и как динамически составлять строку
*    Узнали как работать с перечислениями в C#
*    Начали разбирать вопрос написания классов в C#

## Задачи с leetcode

Периодически, я буду подкидывать вам задачки с **leetcode.com**. Для их автоматического тестирования необходимо зарегистрироваться. В проекте будет присутствовать файл `Submissions.md` - вставьте туда скриншот вкладки `Submissions` с **leetcode** (пример ниже). Для этого достаточно нажать (в Windows 10) `Win+Shift+S` и выделить область - скриншот будет скопирован в буфер обмена. Если вставить его с помощью `Ctrl+V` в `.md`-файл в replit то он автоматически загрузится в проект и вставится в документ.

## Драгоценные камни (8 баллов)

    Источник: https://leetcode.com/problems/jewels-and-stones/

В этой задаче камни, обычные и драгоценные, обозначаются одной из больших или маленьких латинских букв. Вам даны даются две строки: jewels, в которой перечислены драгоценные камни, и stones, в которой перечислены имеющиеся у вас камни. Вам необходимо посчитать, сколько у вас драгоценных камней.

    ⚠ Обратите внимание: `a` и `A` - это разные камни.

## Консольный ввод (4 балла)

Обратите внимание: на **leetcode** вам предлагается реализовать метод класса `Solution`, которому передаются две уже готовых строки.

В replit вставьте этот класс, не заменяя класса Program. В `Program.Main` реализуйте консольный ввод данных (с последующим их разбором и разделением) для задачи в формате, представленном ниже, а также запуск вашего решения и печать ответа.
Формат входных данных:

```
jewels = "aA", stones = "aAAbbbb"
```

   Результат работы: `submit` в `replit` с выполнением вышеуказанных условий