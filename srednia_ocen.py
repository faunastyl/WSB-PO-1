"""
ZADANIE:
Poproś ucznia o podanie ocen z wybranych przedmiotów na pierwsze i drugie półrocze.
Oblicz średnią ocen półrocznych i na zakonczenie roku. Podaj je uczniowi. /
Ask the student to submit their grades in the selected subjects for the first and second semesters.
Calculate the average of the half-year and end-of-year marks. Give these to the student.
"""

tab = ['matematyka', 'fizyka', 'chemia', 'biologia', 'język angielski']
oceny_sem1 = []
oceny_sem2 = []

# Obliczenia dla semestru pierwszego
print("Podaj oceny za pierwszy semestr:")
for przedmiot in tab:
    ocena_sem1 = input(przedmiot + " ")
    oceny_sem1.append(ocena_sem1)
    
sem1 = [int(x) for x in oceny_sem1]
#print(sem1)

# Obliczenia dla semestru drugiego
print("Podaj oceny za drugi semestr:")
for przedmiot in tab:
    ocena_sem2 = input(przedmiot + " ")
    oceny_sem2.append(ocena_sem2)
    
sem2 = [int(x) for x in oceny_sem2]
#print(sem2)

srednia_sem1 = sum(sem1) / len(sem1)
srednia_sem2 = sum(sem2) / len(sem2)
srednia_roczna = (srednia_sem1 + srednia_sem2) / 2

sem = [sem1, sem2]
#print(sem)

print("średnia semestru pierwszego: ", srednia_sem1)
print("średnia semestru drugiego: ", srednia_sem2)
print("średnia ocena roczna: ", srednia_roczna)
