dodatkowa tabela w bazie - miejscowosic
tabela dodawana przez migracje
interfejs by aplikacja pamietala w pamieci serwera i json

//////////2018-04-22//////////

ETAP I
-operacje CRUD (Create, Read, Update, Delete)
-Widok nie powinien korzystać z Modelu tylko z ViewModelu
--ConferenceUserViewModel (do wyświetlania userów)
--AddEditConferenceUserViewModel

ETAP II
Jeden widok (CRUD) wraz z odpowiednim(nimi) ViewModelami
--ConferenceViewModel (ConferenceUserViewModel, AddEditConferenceUserViewModel)

WALIDACJA Danych!!!
Partial VIEW

//////////2018-04-25//////////

1. Strona z wpisaniem maila
2. My szukamy usera o takim mailu
(jak znajdujemy to wysylamy jak nie to mowiemy ze wysylamy ale nie wysylamy)
3. Znaleźlismy usera (czyli mamy jego: mail, id, cretedDate)
4. generujemy lina z parametrami: id i hash
http://asdfsfsfs/controler/akcja?id=333&hash=sdfdsfgdsfgdsfg
5. Uzytkownik klika w link wyslany na maila
6. Otwiera sie strona z mozliwoscią ustalenia nowego hasła (dwa pola)
(szukamy usera w bazi o id = id wyslanym w parametrze)
A) jesli go znajdziemy to:
tworzymy hash na podstawie danych wyciagnietych z bazy i porownujemy go z 
hashem zaszytym w linku
B) jesli hashe są ok to zmieniamy hasło
ad. A jesli nie, robta co chceta
ad. B jesli nie, redirect to index