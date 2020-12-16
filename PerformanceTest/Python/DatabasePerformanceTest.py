from sqlalchemy import create_engine


class UnicodeEntry:
    def __init__(self, ID: int, UnicodeCharacter: str, PREVIOUS: int, NEXT: int):
        self.ID = ID
        self.UnicodeCharacter = UnicodeCharacter
        self.PREVIOUS = PREVIOUS
        self.NEXT = NEXT


def execute():
    unicode_entry_list = []

    try:
        engine = create_engine("sqlite:///unicode.sqlite")
        connection = engine.connect()
        unicode_characters = connection.execute("SELECT * FROM unicode;")
        for row in unicode_characters:
            unicode_entry_list.append(
                UnicodeEntry(
                    row[0],
                    row[1],
                    row[2],
                    row[3]
                )
            )
    except Exception as e:
        print(e)
