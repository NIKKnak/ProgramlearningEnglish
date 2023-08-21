﻿

using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

class Program
{
    private static Dictionary<string, string> Words = new Dictionary<string, string>()
    {

        {"взрослый","adult"},
{"возраст","age"},
{"малыш","baby"},
{"рождение","birth"},
{"мальчик","boy"},
{"ребенок","child"},
{"детство","childhood"},
{"девочка","girl"},
{"человек","human"},
{"жизнь","life"},
{"мужчина","man"},
{"имя","name"},
{"люди","people"},
{"персона","person"},
{"личность","personality"},
{"фамилия","surname"},
{"подросток","teenager"},
{"женщина","woman"},
{"молодой ","youth"},
{"он","he"},
{"ее","her"},
{"его","his"},
{"я","I"},
{"оно","it"},
{"мой","my"},
{"наш","our"},
{"она","she"},
{"они","they"},
{"мы ","we"},
{"рука","arm"},
{"спина","back"},
{"живот","belly"},
{"кровь","blood"},
{"тело","body"},
{"кость","bone"},
{"мозг","brain"},
{"щека","cheek"},
{"грудь","chest"},
{"подбородок","chin"},
{"ухо","ear"},
{"локоть","elbow"},
{"глаз","eye"},
{"бровь","eyebrow"},
{"ресница","eyelash"},
{"лицо","face"},
{"палец","finger"},
{"кулак","fist"},
{"ступня","foot"},
{"лоб","forehead"},
{"волосы","hair"},
{"кисть руки","hand"},
{"сердце","heart"},
{"пятка","heel"},
{"бедро","hip"},
{"челюсть","jaw"},
{"почка","kidney"},
{"колено","knee"},
{"нога","leg"},
{"губы","lips"},
{"мизинец","little finger"},
{"печень","liver"},
{"легкое","lung"},
{"рот","mouth"},
{"мышца","muscle"},
{"ноготь","nail"},
{"шея","neck"},
{"нерв","nerve"},
{"нос","nose"},
{"ладонь","palm"},
{"ребро","rib"},
{"безымянный палец","ring finger"},
{"скелет","skeleton"},
{"кожа","skin"},
{"череп","skull"},
{"желудок","stomach"},
{"горло","throat"},
{"большой палец","thumb"},
{"палец на ноге","toe"},
{"язык","tongue"},
{"зуб","tooth"},
{"запястье ","wrist"},
{"быть","be"},
{"дышать","breathe"},
{"слышать","hear"},
{"держать","hold"},
{"лежать","lie"},
{"смотреть","look"},
{"видеть","see"},
{"сидеть","sit"},
{"говорить","speak"},
{"трогать","touch"},
{"ходить ","walk"},
{"привлекательный","attractive"},
{"лысый","bald"},
{"борода","beard"},
{"красивый","beautiful"},
{"красота","beauty"},
{"белокурый","blond"},
{"густой","bushy"},
{"общий","common"},
{"кудрявый","curly"},
{"милый","cute"},
{"темный","dark"},
{"толстый","fat"},
{"фигура","figure"},
{"румянец","flush"},
{"веснушки","freckles"},
{"рыжий","ginger"},
{"прическа","haircut"},
{"рост","height"},
{"усы","moustache"},
{"овальный","oval"},
{"бледный","pale"},
{"пухлый","plump"},
{"круглый","round"},
{"короткий","short"},
{"тонкий","slim"},
{"квадратный","square"},
{"прямой","straight"},
{"высокий","tall"},
{"худой","thin"},
{"уродливый","ugly"},
{"волнистый","wavy"},
{"вес ","weight"},
{"активный","active"},
{"злой","angry"},
{"грустный","blue"},
{"скучный","boring"},
{"храбрый","brave"},
{"спокойный","calm"},
{"осторожный","careful"},
{"характер","character"},
{"радостный","cheerful"},
{"умный","clever"},
{"сбитый с толку","confused"},
{"креативный","creative"},
{"жестокий","cruel"},
{"любопытный","curious"},
{"легкий на подъем","easy-going"},
{"эмоциональный","emotional"},
{"взволнованный","excited"},
{"честный","fair"},
{"дружелюбный","friendly"},
{"щедрый","generous"},
{"гениальный","genius"},
{"мягкий","gentle"},
{"довольный","glad"},
{"жадный","greedy"},
{"счастливый","happy"},
{"добрый","kind"},
{"ленивый","lazy"},
{"верный","loyal"},
{"удачливый","lucky"},
{"хмурый","moody"},
{"нервный","nervous"},
{"открытый","open"},
{"оптимистичный","optimistic"},
{"терпеливый","patient"},
{"гордый","proud"},
{"тихий","quiet"},
{"надежный","reliable"},
{"романтичный","romantic"},
{"грубый","rude"},
{"стеснительный","shy"},
{"чувствительный","sensitive"},
{"серьезный","serious"},
{"глупый","stupid"},
{"талантливый","talented"},
{"жесткий","tough"},
{"расстроенный","upset"},
{"мудрый","wise"},
{"остроумный ","witty"},
{"рассказывать","to tell"},
{"стараться ","to try"},
{"усыновление","adoption"},
{"тетя","aunt"},
{"парень","boyfriend"},
{"невеста","bride"},
{"брат","brother"},
{"дочь","daughter"},
{"развод","divorce"},
{"помолвка","engagement"},
{"семья","family"},
{"отец","father"},
{"друг","friend"},
{"девушка","girlfriend"},
{"крестный отец","godfather"},
{"крестная мать","godmother"},
{"внуки","grandchildren"},
{"внучка","granddaughter"},
{"дедушка","grandfather"},
{"бабушка","grandmother"},
{"внук","grandson"},
{"муж","husband"},
{"любовник","lover"},
{"брак","marriage"},
{"мать","mother"},
{"племянник","nephew"},
{"племянница","niece"},
{"родители","parents"},
{"родственник","relative"},
{"сестра","sister"},
{"сын","son"},
{"сводный брат","stepbrother"},
{"отчим","stepfather"},
{"мачеха","stepmother"},
{"сводная сестра","stepsister"},
{"близнецы","twins"},
{"дядя","uncle"},
{"свадьба","wedding"},
{"вдова","widow"},
{"вдовец","widower"},
{"жена ","wife"},
{"заботиться","to care"},
{"любить","to love"},
{"скучать","to miss"},
{"поддерживать ","to support"},
{"ремень","belt"},
{"блузка","blouse"},
{"ботинки","boots"},
{"браслет","bracelet"},
{"кепка","cap"},
{"цепочка","chain"},
{"плащ","cloak"},
{"одежда","clothes"},
{"пальто","coat"},
{"платье","dress"},
{"серьги","earrings"},
{"шляпа","hat"},
{"сапоги","high boots"},
{"пиджак","jacket"},
{"джинсы","jeans"},
{"ожерелье","necklace"},
{"карман","pocket"},
{"пижама","pyjamas"},
{"дождевик","raincoat"},
{"кольцо","ring"},
{"рубашка","shirt"},
{"туфли","shoes"},
{"шорты","shorts"},
{"юбка","skirt"},
{"тапочки","slippers"},
{"носки","socks"},
{"костюм","suit"},
{"свитер","sweater"},
{"кроссовки","trainers"},
{"футболка","T-shirt"},
{"зонт","umbrella"},
{"униформа","uniform"},
{"застежка ","zip"},
{"яблоко","apple"},
{"бекон","bacon"},
{"банан","banana"},
{"говядина","beef"},
{"ягоды","berries"},
{"печенье","biscuits"},
{"завтрак","breakfast"},
{"масло","butter"},
{"морковь","carrot"},
{"хлопья","cereal"},
{"курица","chicken"},
{"кофе","coffee"},
{"кукуруза","corn"},
{"огурец","cucumber"},
{"ужин","dinner"},
{"напитки","drinks"},
{"утка","duck"},
{"баклажан","aubergine"},
{"рыба","fish"},
{"фрукты","fruits"},
{"чеснок","garlic"},
{"виноград","grapes"},
{"ветчина","ham"},
{"варенье","jam"},
{"сок","juice"},
{"лимон","lemon"},
{"обед","lunch"},
{"молоко","milk"},
{"гриб","mushroom"},
{"орехи","nuts"},
{"лук","onion"},
{"блинчик","pancake"},
{"персик","peach"},
{"перец","pepper"},
{"ананас","pineapple"},
{"слива","plum"},
{"свинина","pork"},
{"картофель","potato"},
{"лосось","salmon"},
{"сэндвич","sandwich"},
{"колбаса","sausage"},
{"креветка","shrimp"},
{"перекус","snack"},
{"газировка","soda"},
{"клубника","strawberry"},
{"вкус","taste"},
{"чай","tea"},
{"тост","toast"},
{"помидор","tomato"},
{"индейка","turkey"},
{"овощи","vegetables"},
{"вода","water"},
{"арбуз","watermelon"},
{"йогурт ","yoghurt"},
{"печь","to bake"},
{"кипеть, варить","to boil"},
{"готовить","to cook"},
{"охлаждать","to cool"},
{"резать","to cut"},
{"пить","to drink"},
{"есть","to eat"},
{"жарить","to fry"},
{"подогревать","to heat"},
{"тушить","to stew"},
{"пробовать ","to taste"},
{"актер","actor"},
{"художник","artist"},
{"перерыв","break"},
{"карьера","career"},
{"компания","company"},
{"повар","cook"},
{"дизайнер","designer"},
{"директор","director"},
{"врач","doctor"},
{"инженер","engineer"},
{"пожарный","fireman"},
{"домохозяйка","housewife"},
{"собеседование","interview"},
{"работа","job"},
{"журналист","journalist"},
{"юрист","lawyer"},
{"встреча","meeting"},
{"деньги","money"},
{"музыкант","musician"},
{"офис","office"},
{"фотограф","photographer"},
{"полицейский","policeman"},
{"профессионал","professional"},
{"программист","programmer"},
{"ученик","pupil"},
{"зарплата","salary"},
{"ученый","scientist"},
{"певец","singer"},
{"спортсмен","sportsman"},
{"навык","skill"},
{"студент","student"},
{"задача","task"},
{"учитель","teacher"},
{"зарабатывать","to earn"},
{"учить что-либо","to learn"},
{"управлять","to manage"},
{"заказывать","to order"},
{"организовывать","to organise"},
{"учить","to study"},
{"учить, преподавать","to teach"},
{"работать ","to work"},
{"квартира","apartment"},
{"подвал","basement"},
{"потолок","ceiling"},
{"пол","floor"},
{"дом","home"},
{"сосед","neighbour"},
{"крыша","roof"},
{"лестница","stairs"},
{"стена","wall"},
{"двор","yard"},
{"кресло","armchair"},
{"книжный шкаф","bookcase"},
{"ковер","carpet"},
{"кофейный столик","coffee table"},
{"компьютер","computer"},
{"шторы","curtains"},
{"рабочий стол","desk"},
{"лампа","lamp"},
{"ноутбук","laptop"},
{"гостиная","living room"},
{"картина","painting"},
{"рамка для фотографий","picture frame"},
{"диван","sofa"},
{"телевизор","TV"},
{"ванна","bath"},
{"банный халат","bathrobe"},
{"ванная комната","bathroom"},
{"пузырьки","bubbles"},
{"зеркало","mirror"},
{"бритва","razor"},
{"шампунь","shampoo"},
{"душ","shower"},
{"мыло","soap"},
{"губка","sponge"},
{"унитаз","toilet"},
{"зубная щетка","toothbrush"},
{"зубная паста","toothpaste"},
{"полотенце","towel"},
{"будильник","alarm clock"},
{"кровать","bed"},
{"спальня","bedroom"},
{"одеяло","blanket"},
{"платяной шкаф","closet"},
{"расческа","hairbrush"},
{"вешалка","hanger"},
{"выключатель света","light switch"},
{"телефон","phone"},
{"подушка","pillow"},
{"простыня","sheet"},
{"миска","bowl"},
{"стул","chair"},
{"плита","cooker"},
{"чашка","cup"},
{"вилка","fork"},
{"морозильная камера","freezer"},
{"холодильник","fridge"},
{"бокал","glass"},
{"чайник","kettle"},
{"кухня","kitchen"},
{"нож","knife"},
{"кружка","mug"},
{"тарелка","plate"},
{"ложка","spoon"},
{"стол","table"},
{"чистить зубы","to brush teeth"},
{"чистить","to clean"},
{"сушить","to dry"},
{"жить","to live"},
{"спать","to sleep"},
{"принимать ванну","to take a bath"},
{"мыть ","to wash"},
{"баскетбол","basketball"},
{"бильярд","billiards"},
{"книга","book"},
{"боулинг","bowling"},
{"танец","dance"},
{"карты","cards"},
{"шахматы","chess"},
{"кино","cinema"},
{"цирк","circus"},
{"коллекционирование","collecting"},
{"комиксы","comics"},
{"компьютерные игры","computer games"},
{"кроссворды","crosswords"},
{"дайвинг","diving"},
{"рисование","drawing"},
{"рыбалка","fishing"},
{"фитнес","fitness"},
{"футбол","football"},
{"хоккей","hockey"},
{"охота","hunt"},
{"вязание","knitting"},
{"модель","model"},
{"музыка","music"},
{"фотография","photo"},
{"поэзия","poetry"},
{"чтение","reading"},
{"бег","running"},
{"скульптура","sculpture"},
{"шопинг","shopping"},
{"пение","singing"},
{"катание на лыжах","skiing"},
{"плавание","swimming"},
{"теннис","tennis"},
{"театр","theatre"},
{"волейбол","volleyball"},
{"йога","yoga"},
{"танцевать","to dance"},
{"кататься на велосипеде","to do cycling"},
{"заниматься садоводством","to do gardening"},
{"рисовать","to draw"},
{"собирать грибы","to go mushrooming"},
{"играть на гитаре","to play the guitar"},
{"играть на пианино","to play the piano"},
{"читать","to read"},
{"бегать","to run"},
{"петь","to sing"},
{"плавать ","to swim"},
{"агентство","agency"},
{"авиалинии","airlines"},
{"аэропорт","airport"},
{"достопримечательности","attractions"},
{"рюкзак","backpack"},
{"сумка","bag"},
{"багаж","baggage"},
{"пляж","beach"},
{"велосипед","bicycle"},
{"костер","bonfire"},
{"граница","border"},
{"загорелый","bronzed"},
{"автобус","bus"},
{"лагерь","camp"},
{"столица","capital"},
{"машина","car"},
{"город","city"},
{"страна","country"},
{"круиз","cruise"},
{"валюта","currency"},
{"направление","direction"},
{"восток","east"},
{"экзотический","exotic"},
{"иностранный","foreign"},
{"иностранец","foreigner"},
{"поход","hike"},
{"отель, гостиница","hotel"},
{"путешествие","journey"},
{"местный","local"},
{"карта","map"},
{"мотоцикл","motorcycle"},
{"гора","mountain"},
{"север","north"},
{"паспорт","passport"},
{"самолет","plane"},
{"открытка","postcard"},
{"железная дорога","railway"},
{"отдых","rest"},
{"номер, комната","room"},
{"маршрут","route"},
{"корабль","ship"},
{"юг","south"},
{"сувенир","souvenir"},
{"чемодан","suitcase"},
{"такси","taxi"},
{"палатка","tent"},
{"билет","ticket"},
{"туризм","tourism"},
{"поезд","train"},
{"поездка","trip"},
{"отпуск","vacation"},
{"виза","visa"},
{"запад","west"},
{"прибыть","to arrive"},
{"забронировать","to book"},
{"купить","to buy"},
{"пересаживаться на","to change to"},
{"загорать","to get a suntan"},
{"отправляться за границу","to go abroad"},
{"приземляться","to land"},
{"отдыхать ","to rest"},
{"черный","black"},
{"синий","blue"},
{"коричневый","brown"},
{"цвет","colour"},
{"темно-синий","dark blue"},
{"золотистый","gold"},
{"зеленый","green"},
{"серый","grey"},
{"голубой","light blue"},
{"оранжевый","orange"},
{"розовый","pink"},
{"красный","red"},
{"оттенок","shade"},
{"серебристый","silver"},
{"фиолетовый","violet"},
{"белый","white"},
{"желтый","yellow"},
{"красить ","to paint"},
{"плохой","bad"},
{"большой","big"},
{"круг","circle"},
{"прохладный","cool"},
{"далекий","far"},
{"быстрый","fast"},
{"пушистый","fluffy"},
{"хороший","good"},
{"тяжелый","heavy"},
{"горячий","hot"},
{"крупный","large"},
{"длина","length"},
{"легкий","light"},
{"линия","line"},
{"длинный","long"},
{"громкий","loud"},
{"низкий","low"},
{"новый","new"},
{"старый","old"},
{"форма","shape"},
{"острый","sharp"},
{"размер","size"},
{"медленный","slow"},
{"маленький","small"},
{"гладкий","smooth"},
{"скорость","speed"},
{"квадрат","square"},
{"теплый","warm"},
{"время после полудня","afternoon"},
{"век","century"},
{"дата","date"},
{"день","day"},
{"десятилетие","decade"},
{"вечер","evening"},
{"час","hour"},
{"полночь","midnight"},
{"минута","minute"},
{"месяц","month"},
{"утро","morning"},
{"ночь","night"},
{"секунда","second"},
{"время","time"},
{"неделя","week"},
{"будни","weekdays"},
{"выходные","weekend"},
{"год","year"},
{"понедельник","Monday"},
{"вторник","Tuesday"},
{"среда","Wednesday"},
{"четверг","Thursday"},
{"пятница","Friday"},
{"суббота","Saturday"},
{"воскресенье","Sunday"},
{"зима","winter"},
{"весна","spring"},
{"лето","summer"},
{"осень","autumn"},
{"январь","January"},
{"февраль","February"},
{"март","March"},
{"апрель","April"},
{"май","May"},
{"июнь","June"},
{"июль","July"},
{"август","August"},
{"сентябрь","September"},
{"октябрь","October"},
{"ноябрь","November"},
{"декабрь ","December"},
{"один","one"},
{"два","two"},
{"три","three"},
{"четыре","four"},
{"пять","five"},
{"шесть","six"},
{"семь","seven"},
{"восемь","eight"},
{"девять","nine"},
{"десять","ten"},
{"одиннадцать","eleven"},
{"двенадцать","twelve"},
{"тринадцать","thirteen"},
{"четырнадцать","fourteen"},
{"пятнадцать","fifteen"},
{"шестнадцать","sixteen"},
{"семнадцать","seventeen"},
{"восемнадцать","eighteen"},
{"девятнадцать","nineteen"},
{"двадцать","twenty"},
{"двадцать один","twenty-one"},
{"двадцать два","twenty-two"},
{"двадцать три","twenty-three"},
{"двадцать четыре","twenty-four"},
{"двадцать пять","twenty-five"},
{"двадцать шесть","twenty-six"},
{"двадцать семь","twenty-seven"},
{"двадцать восемь","twenty-eight"},
{"двадцать девять ","twenty-nine"},
{"тридцать","thirty"},
{"сорок","forty"},
{"пятьдесят","fifty"},
{"шестьдесят","sixty"},
{"семьдесят","seventy"},
{"восемьдесят","eighty"},
{"девяносто","ninety"},
{"сто","hundred"},
{"тысяча","thousand"},
{"миллион","million"},
{"миллиард ","billion"},
{"воздух","air"},
{"метель","blizza"},
{"чистый","clear"},
{"облако","cloud"},
{"облачный","cloudy"},
{"холод, холодный","cold"},
{"туман","fog"},
{"туманный","foggy"},
{"морозный","frosty"},
{"жаркий","hot"},
{"лед","ice"},
{"ледяной","icy"},
{"молния","lightning"},
{"луна","moon"},
{"грязь","mud"},
{"лужа","puddle"},
{"дождь","rain"},
{"радуга","rainbow"},
{"дождливый","rainy"},
{"небо","sky"},
{"снег","snow"},
{"снегопад","snowfall"},
{"снежинка","snowflake"},
{"снежный","snowy"},
{"звезда","star"},
{"звездный","starry"},
{"солнце","sun"},
{"солнечный свет","sunlight"},
{"солнечный","sunny"},
{"рассвет","sunrise"},
{"закат","sunset"},
{"гром","thunder"},
{"гроза","thunderstorm"},
{"погода","weather"},
{"ветер","wind"},
{"ветреный","windy"},
{"стучать","to beat"},
{"дуть","to blow"},
{"покрывать","to cover up"},
{"темнеть","to darken"},
{"капать","to drip"},
{"падать","to fall"},
{"светлеть","to lighten"},
{"таять ","to melt"},
{"пещера","cave"},
{"скала","cliff"},
{"пустыня","desert"},
{"пыль","dust"},
{"поле","field"},
{"лес","forest"},
{"земля","ground"},
{"холм","hill"},
{"остров","island"},
{"джунгли","jungle"},
{"озеро","lake"},
{"природа","nature"},
{"океан","ocean"},
{"пруд","pond"},
{"река","river"},
{"песок","sand"},
{"море","sea"},
{"камень","stone"},
{"ручей","stream"},
{"болото","swamp"},
{"волна ","wave"},
{"животное","animal"},
{"клюв","beak"},
{"коготь","claw"},
{"перо","feather"},
{"шерсть","fur"},
{"бык","bull"},
{"кошка","cat"},
{"корова","cow"},
{"собака","dog"},
{"осел","donkey"},
{"коза","goat"},
{"гусь","goose"},
{"морская свинка","guinea pig"},
{"хомяк","hamster"},
{"лошадь","horse"},
{"котенок","kitten"},
{"мышь","mouse"},
{"попугай","parrot"},
{"питомец","pet"},
{"свинья","pig"},
{"щенок","puppy"},
{"кролик","rabbit"},
{"крыса","rat"},
{"овца","sheep"},
{"медведь","bear"},
{"верблюд","camel"},
{"крокодил","crocodile"},
{"олень","deer"},
{"слон","elephant"},
{"лиса","fox"},
{"жираф","giraffe"},
{"бегемот","hippo"},
{"кенгуру","kangaroo"},
{"лев","lion"},
{"обезьяна","monkey"},
{"панда","panda"},
{"носорог","rhino"},
{"змея","snake"},
{"тигр","tiger"},
{"дикий","wild"},
{"волк","wolf"},
{"пчела","bee"},
{"жук","bug"},
{"бабочка","butterfly"},
{"муха","fly"},
{"насекомое","insect"},
{"паук","spider"},
{"птица","bird"},
{"орел","eagle"},
{"сова","owl"},
{"пингвин","penguin"},
{"голубь","pigeon"},
{"ворон","raven"},
{"воробей","sparrow"},
{"лебедь","swan"},
{"лаять","to bark"},
{"кусать","to bite"},
{"ловить","to catch"},
{"кормить","to feed"},
{"летать","to fly"},
{"шипеть","to hiss"},
{"гладить","to pet"},
{"мурлыкать","to purr"},
{"кричать ","to scream"},
{"куст","bush"},
{"кактус","cactus"},
{"цветок","flower"},
{"трава","grass"},
{"лист","leaf"},
{"лилия","lily"},
{"дуб","oak"},
{"сосна","pine"},
{"корень","root"},
{"роза","rose"},
{"дерево","tree"},
{"цвести","to bloom"},
{"плодоносить","to fruit"},
{"расти","to grow"},
{"сажать","to plant"},
{"поливать ","to water"},
{"Рождество","Christmas"},
{"гирлянды","coloured lights"},
{"украшения","decorations"},
{"гость","guest"},
{"праздник","holiday"},
{"Новый год","New Year"},
{"новогодняя елка","New Year’s tree"},
{"подарок","present"},
{"снеговик","snowman"},
{"угощение","treat"},
{"воздушный шар","balloon"},
{"день рождения","birthday"},
{"торт","cake"},
{"свеча","candle"},
{"вечеринка","party"},
{"желание","wish"},
{"родиться","to be born"},
{"праздновать","to celebrate"},
{"поздравлять","to congratulate"},
{"наслаждаться","to enjoy"},
{"становиться старше","to get older"},
{"развлекаться","to have fun"},
{"пригласить","to invite"},
{"нравиться","to like"},
{"загадать желание","to make a wish"},
{"готовиться","to prepare"},
{"навещать ","to visit"},
{"булочная, пекарня","bakery"},
{"банк","bank"},
{"скамья","bench"},
{"книжный магазин","bookshop"},
{"мост","bridge"},
{"здание","building"},
{"кафе","cafe"},
{"парковка","car park"},
{"собор","cathedral"},
{"дешевый","cheap"},
{"церковь","church"},
{"монета","coin"},
{"угол","corner"},
{"перекресток","crossroads"},
{"покупатель","customer"},
{"тупик","dead end"},
{"дорогой","expensive"},
{"фонтан","fountain"},
{"больница","hospital"},
{"налево","left"},
{"библиотека","library"},
{"лифт","lift"},
{"торговый центр","mall"},
{"рынок","market"},
{"памятник","monument"},
{"музей","museum"},
{"ночной клуб","nightclub"},
{"парк","park"},
{"цена","price"},
{"общественный транспорт","public transport"},
{"чек","receipt"},
{"ресторан","restaurant"},
{"направо","right"},
{"дорога","road"},
{"распродажа","sale"},
{"школа","school"},
{"магазин","shop"},
{"площадь","square"},
{"стадион","stadium"},
{"станция","station"},
{"остановка","stop"},
{"улица","street"},
{"подземный переход, метро","subway"},
{"супермаркет","supermarket"},
{"университет","university"},
{"вид","view"},
{"путь","way"},
{"зоопарк","zoo"},
{"стоить","to cost"},
{"пересекать, переходить","to cross"},
{"находить","to find"},
{"идти","to go"},
{"осматривать достопримечательности","to go sightseeing"},
{"платить","to pay"},
{"продавать","to sell"},
{"остановиться ","to stop"},
{"и","and"},
{"как","as"},
{"потому что","because"},
{"но","but"},
{"если","if"},
{"или","or"},
{"чем","than"},
{"который","that"},
{"что","what"},
{"когда","when"},
{"где","where"},
{"который1","which1"},
{"кто","who"},
{"кому","whom"},
{"чей","whose"},
{"однако ","yet"},
{"над","above"},
{"у, в, на","at"},
{"за","behind"},
{"ниже","below"},
{"между","between"},
{"у","by"},
{"в","in"},
{"на","on"},
{"под","under"},
{"после","after"},
{"до","before"},
{"к","by"},
{"во время","during"},
{"с тех пор, как","since"},
{"пока","until"},
{"из-за","because of"},
{"для, за, из-за","for"},
{"от","from"},
{"благодаря","thanks to"},
{"благодаря, из-за","through"},
{"через","across"},
{"вдоль","along"},
{"из","out"},


    };
    public static void PrintWindow(int correct = 0)
    {
        Console.WriteLine("Учим английский");
        Console.WriteLine("Для выходи из программы введите 'exit' ");
        Console.WriteLine($"Правильных ответов: {correct}");
        Console.WriteLine();
    }
    public static string look()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, Words.Count);
        string randomKey = Words.Keys.ElementAt(randomIndex);
        string randomValue = Words[randomKey];
        return randomKey;
    }
    static void Main(string[] args)
    {

        int correctAnswer = 0;
        bool exit = true;
        while (exit)
        {
            PrintWindow(correctAnswer);
            string randomWord = look();

            Console.WriteLine($"Как по английски будет  '{randomWord}'  ?"); ;

            string enterWord = Console.ReadLine().ToLower();

            if (enterWord == "exit")
            {
                exit = false;
                break;
            }

            else if (Words[randomWord] == enterWord)
            {
                Console.WriteLine("good!!!");
                correctAnswer++;
                Console.ReadKey();
                Console.Clear();

            }
            else
            {
                Console.Write($"No: правильный ответ {Words[randomWord]}");
                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}