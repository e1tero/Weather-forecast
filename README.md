# Weather forecast

RU: Симулятор погоды. Моделируем погоду по дням. Пусть состояние 1 – ясно, 2 – облачно, 3 – пасмурно. Единица времени = 1 день. Зададим интенсивности переходов, например, следующей матрицей инфинитезимальных коэффициентов:

-0,4; 0,3; 0,1
0,4; -0,8; 0,4
0,1; 0,4; -0,5

Переход может произойти несколько раз за день (таймер следует настроить на более короткий интервал, например, 1 час).

Выполните моделирование в «реальном» времени с визуализацией данных.


ENG: Weather simulator. We simulate the weather by day. Let state 1 - clear, 2 - cloudy, 3 - cloudy. Time unit = 1 day. Let us set the transition intensities, for example, by the following matrix of infinitesimal coefficients:

-0.4; 0.3; 0.1
0.4; -0.8; 0,4
0.1; 0.4; -0.5

The transition can occur several times per day (the timer should be set to a shorter interval, for example, 1 hour).

Perform real-time simulations with data visualization.

![alt text](https://lh3.googleusercontent.com/JQSHtq31LsALqGUa4dhm7sU9qNYxCDIGX53iLnwGCFzw_4kMndQNHDZG26zKXn5g4pGoE26myWOYsbEMnGHssoC4Q5vlzi_1y3mMKT939DaOw7qsOPNhfpIAv2nKHOyhm0t9Ve5s)
