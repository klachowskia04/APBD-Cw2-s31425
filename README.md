## Opis projektu
Aplikacja służąca do zarządzania wypożyczalnią sprzętu na uczelni. 
System umożliwia dodawanie sprzętu, rejestrowanie użytkowników, wypożyczanie oraz zwroty wraz z naliczaniem ewentualnych kar.

## Funkcje aplikacji

- Dodawanie użytkowników 
- Dodawanie sprzętu 
- Wypożyczanie sprzętu użytkownikom
- Zwrot sprzętu
- Kontrola dostępności sprzętu
- Oznaczanie sprzętu jako niedostępnego
- Obsługa limitów wypożyczeń
- Naliczanie kar za opóźnienia
- Generowanie raportu

Projekt zawiera klasy:

## Sprzęt
  Equipment – klasa bazowa
  Laptop 
  Projector 
  Camera

## Użytkownicy
  User – klasa bazowa
  Student
  Employee 

## Wypożyczenia
Rental – przechowuje informacje o wypożyczeniu, terminie oraz zwrocie

## Architektura

Projekt został podzielony na warstwy:

  Domain – model domenowy (dane)
  Repositories – przechowywanie danych 
  Services – logika biznesowa
  Program.cs – scenariusz działania aplikacji

## Decyzje projektowe

### Kohezja
Każda klasa ma jedną odpowiedzialność:
Rental – dane wypożyczenia
RentalService – logika wypożyczeń
PenaltyCalculator – naliczanie kar

## Reguły biznesowe

- Student może mieć maksymalnie 2 aktywne wypożyczenia
- Pracownik może mieć maksymalnie 5 aktywnych wypożyczeń
- Nie można wypożyczyć niedostępnego sprzętu
- System blokuje przekroczenie limitu
- Opóźniony zwrot powoduje naliczenie kary


## Uruchomienie

W katalogu projektu:
bash
dotnet build
dotnet run
