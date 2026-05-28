'''
Konwerter temperatur (Celsjusz ↔ Fahrenheit)
Opis: Napisz program, który umożliwia konwersję temperatur między skalą Celsjusza a Fahrenheita.
Użytkownik najpierw wybiera kierunek konwersji:
C – jeśli chce przeliczyć stopnie Celsjusza na Fahrenheity,
lub F – jeśli chc
e przeliczyć stopnie Fahrenheita na Celsjusze.
Następnie podaje wartość temperatury w wybranej skali, a program przelicza ją i wyświetla wynik.
Wykorzystaj instrukcję warunkową do rozróżnienia dwóch przypadków konwersji.
(Wzory konwersji: °F = °C * 1.8 + 32, °C = (°F – 32) / 1.8)
'''

wybor = input("Wybierz konwersję (C/F): ")

temp = float(input("Podaj temperaturę: "))

if wybor == "C":
    wynik = temp * 1.8 + 32
    print("Wynik:", wynik, "F")

elif wybor == "F":
    wynik = (temp - 32) / 1.8
    print("Wynik:", wynik, "C")

else:
    print("Niepoprawny wybór.")

