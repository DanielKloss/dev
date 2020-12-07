file = open("input.txt", "r")
lines = file.read().splitlines()

def buildSchema(lines):
    schema = {}
    for line in lines:
        baseBag = line.split(" contain ")[0]
        schema[baseBag] = {}
        innerBags = line.split(" contain ")[1].split(", ")
        for innerBag in innerBags:
            number = innerBag.split(' ')[0]
            name = innerBag.split(' ', 1)[1]
            name = name.replace(".", "")
            if name[-1:] != 's':
                name = name + 's'
            schema[baseBag][name] = number
    return schema

def canHoldGold(key, value):
    if "shiny gold bags" in value:
        return True
    elif "other bags" in value:
        return False
    elif len(value) > 0:
        for innerKey, innerValue in value.items():
            if canHoldGold(innerKey, schema[innerKey]):
                return True
    return False

def addBags(key, value):
    count = 0
    if "other bags" in value:
        return 0
    else:
        for innerKey, innerValue in value.items():
            for i in range(int(innerValue)):
                count = count + addBags(innerKey, schema[innerKey])
            count = count + int(innerValue)
    return count

def partOne(schema):
    count = 0
    for key, value in schema.items():
        if canHoldGold(key, value):
            count = count+1
    print(count)

def partTwo(schema):
    count = addBags("shiny gold bags", schema["shiny gold bags"])
    print(count)

schema = buildSchema(lines)
partOne(schema)
partTwo(schema)
