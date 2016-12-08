SET IDENTITY_INSERT [dbo].[Tour] ON
INSERT INTO [dbo].[Tour] ([Id], [Name], [ShortDescription], [FullDescription], [CountryId], [HotelId], [Prise], [Image]) VALUES (1, N'Увидеть Париж...', N'Этот тур мы рекомендуем тем, кто рад встрече с Парижем или вновь возвращению к его тайнам! 
Тур открывает полную свободу для самостоятельных прогулок в Париже и заказа дополнительных экскурсий по желанию. Гармоничным дополнением к путешествию является посещение достопримечательностей Берлина, Метца и Люксембурга. Тур подходит тем, кто рассматривает бюджетные варианты поездок. Проживание по маршруту в отелях 2-3 *, а также один ночной переезд. Тур хорошо «откатан» и пользуется немалой популярностью..', N'1 день (Москва - Брест): Выезд с Белорусского вокзала поездом № 27 Москва-Брест в 15:12 (возможны дополнительные поезда).

2 день (Брест - Польша):  Утром прибытие в Брест, размещение в автобусе (пересечение границы возможно на электричке). Переезд по территории Польши (~680 км). Размещение в отеле. 

3 день (Берлин): утром переезд в Берлин (~110 км). Автобусная обзорная экскурсия по Берлину: средневековый район Николайфиртель, знаменитая улица "Под липами" - Unter den Linden - и Курфюрстендам, площадь Александрплац, телебашня, Бранденбургские ворота, Рейхстаг, Дворец Шарлоттенбург. Свободное время без использования автобуса (9 часов). Рекомендуем посетить музей Пергамон, посвященный истории древних цивилизаций или зоопарк, самый большой в Германии. Вечером отправление в Париж (~1000 км), ночной переезд. 

4 день (Париж): прибытие в Париж. Пешеходная экскурсия по Монмартру с посещением собора Сакре-Кер. Свободное время без использования автобуса. Для желающих за доплату катание на кораблике по Сене (15 Е ). Вечером размещение в отеле.

5 день (Париж): автобусная обзорная экскурсия по Парижу: Триумфальная Арка, Елисейские Поля, площадь Согласия, Эйфелева башня, площадь Трокадеро, Марсово поле, набережная Сены, Новый Мост, Дворец Шайо, Пале Рояль, сад Тюильри, Латинский квартал, Сорбонна, Люксембургский Сад, Пантеон, церковь Мадлен, острова Сите и Сен-Луи, Дворец Правосудия - Консьержери, Собор Парижской Богоматери, Гранд Опера. Посещение музея парфюмерии Fragonard. Свободное время. Для желающих за доплату поездка в Версаль с экскурсией по Большому Дворцу с лицензированным гидом (55 евро). 

6 день (Париж): свободное время в Париже. Для желающих за доплату экскурсионная поездка “По замкам Луары” на весь день с посещением замков Шамбор, Шенонсо и Амбуаз. Амбуаз был построен в ХV-XVI вв. В эпоху Ренессанса в замке, при дворе Франциска I, жил Леонардо да Винчи. Здесь находится его усыпальница (внутренний осмотр замка). Шенонсо - самый красивый и необычный из замков с великолепной галереей через реку Шер (внутренний осмотр замка). Шамбор, окруженный самой длинной во Франции стеной, шедевр Ренессанса, повидавший на своём веку множество монархов (внешний осмотр замка) (60 евро взр., 35 евро дети до 16 лет). 

7 день (Париж — Метц): утром отправление в Метц. Знакомство с  Метцем. Размещение в отеле на территории Франции.

8 день (Метц – Люксембург – Польша):  Переезд в Люксембург.  Пешеходная экскурсия по центральной части Люксембурга с осмотром основных достопримечательностей столицы Великого Герцогства.  Отправление в Польшу. Размещение в отеле. 

9 день (Польша – Брест): Отправление в Брест (~650 км). Вечером прибытие в Брест. Пересечение польско-белорусской границы. Отправление в Москву вечерним/ночным поездом. Возможно дополнительные поезда.', 1, 1, CAST(25000.0000 AS Money), N'/img/par.jpg')
INSERT INTO [dbo].[Tour] ([Id], [Name], [ShortDescription], [FullDescription], [CountryId], [HotelId], [Prise], [Image]) VALUES (2, N'Лондон по субботам', N'Недельный тур в Лондон с вылетом по субботам, включающий в себя 4 варианта экскурсионной программы (бюджет, стандарт, супер, королевский), а также вариант тура без экскурсий и возможность бронирования дополнительных экскурсий на выбор. Проживание в центре Лондона в отелях 2-5*. Перелет а/к British Airways и Аэрофлот (см. раздел "транспорт").', N'1 день: прибытие в Лондон. Встреча в аэропорту с представителем принимающей компании. Трансфер в отель. Размещение в отеле. Свободное время.

2 день: завтрак в отеле. Обзорная автобусная экскурсия по Лондону (1). Пешеходная экскурсия по историческому центру Лондона с внешним осмотром Биг-Бена, Дома Парламента, Вестминстерского Аббатства, Трафальгарской площади (2).

3 день: завтрак в отеле. Свободное время.

4 -7 день: завтрак в отеле. Свободное время или по желанию самостоятельное посещение дизайнерского аутлета Ashford. Время для дополнительных экскурсий.

8 день: завтрак в отеле. Выписка из отеля. Свободное время. Трансфер в аэропорт от отеля. Вылет в Москву.

Вариант тура: Лондон стандарт (4 экскурсии)

1 день: прибытие в Лондон. Встреча в аэропорту с представителем принимающей компании. Трансфер в отель. Размещение в отеле. Свободное время.

2 день: завтрак в отеле. Обзорная автобусная экскурсия по Лондону (1).
Пешеходная экскурсия по историческому центру Лондона с внешним осмотром Биг-Бена, Дома Парламента, Вестминстерского Аббатства, Трафальгарской площади (2).

3 день: завтрак в отеле. Пешеходная экскурсия в Национальную Галерею с гидом (3). Пешеходная экскурсия в Британский музей (4).

4 день: завтрак в отеле. Свободное время.

5-7 день: завтрак в отеле. Свободное время или по желанию самостоятельное посещение дизайнерского аутлета Ashford. Время для дополнительных экскурсий.

8 день: завтрак в отеле. Выписка из отеля. Свободное время. Трансфер в аэропорт от отеля. Вылет в Москву.
', 2, 2, CAST(37000.0000 AS Money), N'/img/lond.jpg')
INSERT INTO [dbo].[Tour] ([Id], [Name], [ShortDescription], [FullDescription], [CountryId], [HotelId], [Prise], [Image]) VALUES (3, N'Визит в Амстердам', N'Тур в Амстердам с перелетом регулярными рейсами авиакомпаний "KLM","Аэрофлот" Отели 3*, 4* , много свободного времени для дополнительных экскурсий по городам Голландии.
Возможность выбора экономного тура без экскурсий.', N'Вариант тура эксурсионный.
1 день: прибытие в Амстердам, встреча гидом, трансфер в отель. 
Обзорная экскурсия по Амстердаму с посещением Королевского Дворца, посещение алмазной фабрики, круиз по каналам;

2 день: Экскурсия в Государственный музей. Свободное время.
Вечером – для желающих за дополнительную плату пешеходная экскурсия по кварталу “Красных фонарей”. 

3 день: Свободный день. За дополнительную плату для желающих  автобусная экскурсия в Заансе-Сханс  с посещением музея ветряных мельниц, фабрики деревянных башмаков.

4 день: свободный день. За дополнительную плату для желающих  Автобусная экскурсия в Гаагу и Дельфт.

5 день: Поездка в Заандам (ок. 30 км) с посещением домика Петра I и экскурсия в рыбацкую деревню Волендам.

6 день: свободный день. За дополнительную плату для желающих экскурсия по Северной  Голландии с посещением Голландской Венеции - Giethoorn  и Outlet Batavia ( от 80 евро). 

7 день: Посещение сырного аукциона в Алкмааре с шоу "Катание сыров". (25 марта по 2 сентября).
Во второй половине дня за дополнительную плату для желающих  с 24 марта по 16 мая  посещение парка цветов Keukenhof (от 45 евро/чел+билет в парк цветов 15 евро, оплата на месте в Амстердаме) или экскурсия в музей Ван Гога. 
Трансфер в аэропорт Амстердама, вылет в Москву. 

Вариант тура с 1 экскурсией.

1 день: прибытие в Амстердам, встреча с гидом, трансфер в отель. 
Обзорная экскурсия по Амстердаму с посещением Королевского Дворца, посещение алмазной фабрики, круиз по каналам
2 день: Свободный день. Для желающих возможность присоединения к групповым экскурсиям.
3 день: Свободный день. 
4 день: Свободный день. 
5 день: Свободный день.
6 день: Свободный день. 
7 день: Свободный день. Трансфер в аэропорт Амстердама, вылет в Москву. 

Базовые отели в Амстердаме:
OZO 4*, Blyss*, Sander 3*.', 3, 3, CAST(27000.0000 AS Money), N'/img/amst.jpg')
INSERT INTO [dbo].[Tour] ([Id], [Name], [ShortDescription], [FullDescription], [CountryId], [HotelId], [Prise], [Image]) VALUES (4, N'Зимние каникулы в талине', N'Для тех кто любит себя, желает и может позволить провести праздники неторопливо с комфортом, мы предлагаем наш эксклюзивный тур! Сбалансированная программа с учетом многолетнего опыта, где все продумано до мелочей с большой заботой о наших туристах! На Ваш выбор перелет 1,5 часа и вы на месте или ночной поезд!
Приглашаем на незабываемые Рождественские каникулы в гостеприимной уютной Эстонии! Где, как не здесь можно отдохнуть и расслабиться после активных праздников, подпитаться энергией древних стен, насладиться полезной, а главное очень вкусной и свежей едой, и заодно прикупить всяких деликатесов с собой!!! 

С первых минут Вы влюбитесь в Таллин. Он такой милый и аккуратный, что хочется бесконечно бродить по узким улицам, заглядывать в сувенирные магазинчики и в музеи!', N'1 день (Москва):  
ДЛЯ ЖД туристов: отправление на поезде из Москвы.  

2 день (Москва-Таллинн):  
ДЛЯ ЖД туристов: прибытие в Таллинн.
ДЛЯ АВИА туристов: вылет в Таллинн любым подходящим для Вас рейсом Aeroflot или др. а/к.  Рейсы и стоимость нужно УТОЧНЯТЬ ПРИ БРОНИРОВАНИИ www.dsbw.ru/travel#avia или www.aeroflot.ru
(Возможно организовать встречу и трансфер за дополнительную плату) 
ДЛЯ ТЕХ КТО ХОЧЕТ НАЧАТЬ ТУР ИЗ ПИТЕРА: отправление на АВТОБУСЕ компании Lux Express Group (Балтийский вокзал (360 км.))

Размещение в отеле. При раннем прибытии, вещи можно оставить в бесплатной камере хранение отеля до размещения в номерах. Затем у Вас состоится знакомство с Таллином, и Вы отправитесь на пешеходную экскурсию по Старому городу. Вы увидите Верхний и Нижний город, крупнейшую православную церковь в Эстонии - собор Александра Невского, смотровые площадки, улицы Короткая и Длинная нога, старейшую в Таллинне Домскую церковь XIII в., Ратушу и башню «Толстая Маргарита». После экскурсии свободное время.

3 день (Таллинн):  Завтрак в отеле. 
Сегодня самое время найти долгожданные подарки для себя и своих близких, одеться как никогда красиво и вместе с близкими готовиться к празднованию НОВОГО 2017 ГОДА!!! НОВОГОДНИЙ БАНКЕТ!

4 день (Таллинн):  Поздний завтрак. 
Прекрасный день, чтобы отправиться по лабиринтам старинных улочек Старого города: выпить чашечку кофе или ликера «Вана Таллинн». Мы очень рекомендуем присоединиться к дополнительным экскурсиям (список экскурсий см. в доп. оплачивается). 
Для тех, кто не выбрал доп. экскурсии – свободное время.

5 день (Таллинн-Москва):   Завтрак в отеле. Прогуляйтесь по мощеным улочкам Старого города, загляните в «Beer House», где можно отведать вкусного пива. Для любителей шопинга сегодня второй новогодний праздник: в торговых центрах собраны практически все мировые бренды. 
Время неумолимо идет вперед, и это новогоднее путешествие подходит к концу. Не забудьте купить перед отправлением чего-нибудь вкусного, и Ваш переезд пройдет совсем незаметно. 
Для тех, кто приобретает дополнительные ночи, предлагаем дополнительные экскурсии (список экскурсий см. в доп. оплачивается).

ДЛЯ ЖД туристов:
отправление поездом из Таллинна в Москву.  
ДЛЯ АВИА туристов:
вылет в Москву любым подходящим для Вас рейсом Aeroflot или др. а/к. 
Рейсы и стоимость можно уточнить по ссылке www.dsbw.ru/travel#avia
(Возможно организовать трансфер в аэропорт за дополнительную плату)  
ДЛЯ ТЕХ КТО ХОЧЕТ ЗАКОНЧИТЬ ТУР В ПИТЕРЕ: отправление на АВТОБУСЕ компании Lux Express Group (360 км.)  

6 день (Москва): 
ДЛЯ ЖД туристов: путешествие завершается в Москве.

ВНИМАНИЕ! Дополнительно можно заказать доп. ночи в отелях.', 4, 4, CAST(21000.0000 AS Money), N'/img/est.jpg')
INSERT INTO [dbo].[Tour] ([Id], [Name], [ShortDescription], [FullDescription], [CountryId], [HotelId], [Prise], [Image]) VALUES (6, N'Круиз по Нилу', N'Египет — гостеприимный край яркого солнца и комфортного отдыха, идеально подходит для познавательного туризма. И это не удивительно, ведь на территории Египта сосредоточена треть всех исторических памятников Древнего мира. А комплекс пирамид в Гизе, охраняемый величественным Сфинксом, — единственное из семи чудес света, сохранившееся до наших дней.', N'1 день (среда)
Рано утром отъезд из Хургады (около 6.00) в Асуан.
По прибытии экскурсии: Асуанская плотина, Незавершенный Обелиск.
Отплытие в Ком-Омбо. Осмотр храма в Ком-Омбо.
Отплытие в Эдфу.
2 день (четверг)
Завтрак на корабле.
Экскурсии в Эдфу. Посещение храма Гора.
Ужин на корабле. Отплытие в Луксор.
3 день (пятница)
Завтрак на корабле.
Экскурсии в Луксоре западный берег - Долина Царей, храм царицы Хатшепсут, колоссы Мемнона. Посещение Карнакского храма.
Обед. Стоянка в Луксоре.
Ужин на корабле.
4 день (суббота)
Завтрак на корабле.
Окончание круиза. Возвращение в Хургаду.', 5, 5, CAST(12000.0000 AS Money), N'/img/eg.jpg')
INSERT INTO [dbo].[Tour] ([Id], [Name], [ShortDescription], [FullDescription], [CountryId], [HotelId], [Prise], [Image]) VALUES (7, N'Сокровища трех эпох', N'Стамбул единственный город в мире, соединяющий Европу и Азию. Европейскую половину города рассекает бухта Золотой Рог. Эминёню – Старый город – и в наши дни дышит средневековьем, которое вы также можете почувствовать во время экскурсионных туров в Стамбул на тесных улицах и в древних мечетях. Бейоглу – Новый город - включает торговый портовый район, а также деловой и культурный центр. Меньшая часть Стамбула расположена на азиатской части – Ускюдар. Сообщения между районами на разных берегах Босфора осуществляется посредством паромов и мостов', N'Стамбул единственный город в мире, соединяющий Европу и Азию. Европейскую половину города рассекает бухта Золотой Рог. Эминёню – Старый город – и в наши дни дышит средневековьем, которое вы также можете почувствовать во время экскурсионных туров в Стамбул на тесных улицах и в древних мечетях. Бейоглу – Новый город - включает торговый портовый район, а также деловой и культурный центр. Меньшая часть Стамбула расположена на азиатской части – Ускюдар. Сообщения между районами на разных берегах Босфора осуществляется посредством паромов и мостов.

В районе Султанахмет плотность достопримечательностей превосходит все самые смелые ожидания. Отправившись в туры в Стамбул на выходные, вы вряд ли успеете осмотреть даже половину. Все три эпохи - Римская, Византийская и Османская – выбирали их местом возведения роскошных сооружений. Уникальность собора Святой Софии состоит в том, что изначально он был построен как христианский храм, но после завоевания Константинополя был дополнен минаретами, мозаикой и панно с арабской вязью, после чего превратился в мечеть. Рядом расположилась открытая для туристов Голубая Мечеть – единственное в мире культовое мусульманское сооружение с шестью минаретами. Между ними раскинулась площадь древнего Ипподрома, а в двадцати минутах ходьбы шумит самый большой и один из самых древних базаров в мире Капалы Чарши.

Туроператор по Стамбулу «Ванд» советует вам также побывать во дворце Топкапы с редкой коллекцией сокровищ, в церкви Святой Ирины, в гареме султанов, во дворце Долмабахче, в Цистерне Базилика, а также прогуляться вдоль древних городских стен, которые протянулись на 22 километра через все районы. И обязательно не упустите возможность взглянуть на исторический центр города со смотровой площадки Галатской башни, которая расположена на берегу бухты Золотой Рог.', 6, 6, CAST(10500.0000 AS Money), N'/img/tur.jpg')
SET IDENTITY_INSERT [dbo].[Tour] OFF
