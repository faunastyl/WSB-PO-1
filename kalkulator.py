'''
Zadanie 1: Prosty kalkulator dwóch liczb
Opis: Napisz program, który prosi użytkownika o dwie liczby oraz o wybór operacji arytmetycznej (+, -, * lub /). Następnie, w zależności od wybranego działania, program oblicza wynik i wyświetla go na ekranie. Użyj instrukcji warunkowej (if/elif) do rozpoznania operacji.
Przykład:
Wejście: 10, 20, +
Wyjście: Wynik: 30

'''
def suma(num1, num2):
    return num1 + num2

def sub(num1, num2):
    return num1 - num2

def multi(num1, num2):
    return num1 * num2

def divi(num1, num2):
    if num2 == 0:
        print("Sorry, nie dzielimy przez 0.")
        return None
    return num1 / num2


while True:
    num1 = input(
        "Jestem prostym liczydłem.\n"
        "Jeśli nie chcesz skorzystać z moich usług, wpisz exit:\n"
        "Jeśli chcesz, to podaj pierwszą liczbę: "
    )

    if num1 == "exit":
        print("Dziękujemy, do widzenia!")
        break

    num2 = input("Podaj drugą liczbę: ")
    dz = input("Jakie ma być wykonane działanie (+,-,*,/)?\n")

    if dz == "+":
        wynik = suma(float(num1), float(num2))

    elif dz == "-":
        wynik = sub(float(num1), float(num2))

    elif dz == "*":
        wynik = multi(float(num1), float(num2))

    elif dz == "/":
        wynik = divi(float(num1), float(num2))

    else:
        print("Nieprawidłowe działanie. Spróbuj ponownie.")
        continue

    print("Wynik:", wynik)
