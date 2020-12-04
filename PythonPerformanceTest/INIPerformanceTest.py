import configparser


class IniEntry:
    def __init__(self, SECTION: str, KEY: str, VALUE: str):
        # Not possible to make private variables. possible security issue?
        self.SECTION = SECTION
        self.KEY = KEY
        self.VALUE = VALUE


def execute():
    ini_entries = []
    try:
        config = configparser.ConfigParser()
        config.read("performance_test.ini")
        for section in config.sections():
            for i in range(1, 6):
                ini_entries.append(IniEntry(section, section + str(i), config[section][section + str(i)]))
            last_entry = ini_entries[-1]
            config[last_entry.SECTION][last_entry.KEY] = "Testing around"
            config[last_entry.SECTION][last_entry.KEY] = last_entry.VALUE
    except Exception as e:
        print(e)
