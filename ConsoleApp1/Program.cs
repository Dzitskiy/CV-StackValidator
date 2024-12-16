using VersionChecker;

/*
 Имеется множество устройств, которые соединены между собой. Для устройств
заданы: версия устройства (строка), список дочерних устройств.
Требуется реализовать метод, который возвращает список версий устройств в системе,
без повторов.
 */

var rootDevice = new Device(
    "0", [
            new("2", [
                new("3", [
                    new("4", [])
                    ])
                ]),

    new("3", [
        new("1", [
            new("2", [
                new("5", [])
                ])
        ])
    ])
]);

var temp = new Solver().FindDistinctVersions(rootDevice, x => x.Version) ;

Console.WriteLine(string.Join(", ", temp));

