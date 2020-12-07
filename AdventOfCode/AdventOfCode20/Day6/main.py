file = open("input.txt", "r")
lines = file.read().splitlines()

def partOne(lines):
    numberOfYes = 0
    questions = []

    for line in lines:
        if line == "":
            numberOfYes = numberOfYes + len(questions)
            questions = []
            continue
        for character in line:
            if character in questions:
                continue
            else:
                questions.append(character)
    print(numberOfYes)

def partTwo(lines):
    numberOfYes = 0
    numberOfPeople = 0
    questions = {}

    for line in lines:
        if line == "":
            for answer in questions:
                if questions[answer] == numberOfPeople:
                    numberOfYes = numberOfYes + 1
            questions = {}
            numberOfPeople = 0
            continue
        numberOfPeople = numberOfPeople + 1
        for character in line:
            if character in questions:
                questions[character] = questions[character] + 1
            else:
                questions[character] = 1
    print(numberOfYes)

partOne(lines)
partTwo(lines)
