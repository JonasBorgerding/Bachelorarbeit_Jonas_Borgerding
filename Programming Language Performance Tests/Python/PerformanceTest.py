import time

from DatabasePerformanceTest import execute as db_execute
from INIPerformanceTest import execute as ini_execute

if __name__ == "__main__":
    database_times = ini_file_times = []
    db_execute()
    for i in range(0, 500):
        start = time.time()
        db_execute()
        database_times.append(time.time() - start)
    database_average = sum(database_times) / len(database_times)
    print(f'Die durchschnittliche Zeit für die Datenbankabfrage beträgt: {database_average} Sekunden')

    ini_execute()
    for i in range(0, 500):
        start = time.time()
        ini_execute()
        ini_file_times.append(time.time() - start)
    ini_file_average = sum(ini_file_times) / len(ini_file_times)
    print(f'Die durchschnittliche Zeit für die INI Datei einlesen und ändern beträgt: {ini_file_average} Sekunden')
