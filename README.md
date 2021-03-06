# LCG
## linear congruent generator in console app

#### [RU]

Данный репозиторий создан для лабораторной работы по криптографии на тему: "Шифрование методом гаммирования. Генерация псевдослучайных чисел". В которой мне предстояло программно реализовать Линейный конгруэнтный генератор LCG.

# Линейный конгруэнтный генератор
Линейный конгруэнтный генератор задается рекуррентной формулой: 
gi = a⋅gi–1 + b (mod m), где gi  – i-й член последовательности псевдослучайных чисел; a, b, m и g0 – ключевые параметры. Данная последовательность состоит из целых чисел от 0 до m – 1, и если элементы gi и gj совпадут, то последующие участки последовательности также совпадут: gi+1 = gj+1, gi+2 = gj+2, и т.д. Поэтому последовательность {gi} является периодической, и ее период не превышает m. Для того чтобы период последовательности псевдослучайных чисел, сгенерированной по указанной рекуррентной формуле, был максимальным (равным m), параметры данной формулы должны удовлетворять следующим условиям:
- b и m —взаимно простые числа;
- a – 1 делится на любой простой делитель числа m;
- a – 1 кратно 4, если m кратно 4.

В работе использовался скрипт -> [A .NET Color Console Helper](https://weblog.west-wind.com/posts/2020/Jul/10/A-NET-Console-Color-Helper) 

#### [EN]

This repository was created for a lab work on cryptography on the topic: "Encryption by gamification method. Pseudorandom Number Generation". In which I had to programmatically implement the Linear Congruent Generator LCG.

# Linear Congruent Generator
The linear congruent generator is given by the recurrence formula: 
gi = a⋅gi-1 + b (mod m), where gi is the i-th member of a sequence of pseudorandom numbers; a, b, m and g0 are key parameters. This sequence consists of integers from 0 to m - 1, and if the elements gi and gj coincide, then the subsequent parts of the sequence will also coincide: gi+1 = gj+1, gi+2 = gj+2, etc. So the sequence {gi} is periodic, and its period does not exceed m. In order for the period of the sequence of pseudorandom numbers generated by the above recurrence formula to be maximal (equal to m), the parameters of this formula must satisfy the following conditions:
- b and m are mutually prime numbers;
- a - 1 is divisible by any prime divisor of m;
- a - 1 is a multiple of 4, if m is a multiple of 4.

We used the script -> [A .NET Color Console Helper](https://weblog.west-wind.com/posts/2020/Jul/10/A-NET-Console-Color-Helper) 




