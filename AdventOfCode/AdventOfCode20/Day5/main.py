import math

file = open("input.txt", "r")
lines = file.read().splitlines()

def findSeatId(line):
        startRow = 0
        endRow = 127
        startColumn = 0
        endColumn = 7
        for character in line:
            if character == "F":
                endRow = math.ceil((endRow+startRow)/2)
            elif character == "B":
                startRow = math.ceil((endRow+startRow)/2)
            elif character == "L":
                endColumn = math.ceil((endColumn+startColumn)/2)
            elif character == "R":
                startColumn = math.ceil((endColumn+startColumn)/2)
        seatId = startRow * 8 + startColumn
        return seatId

def partOne(lines):
    highestId = 0
    for line in lines:
        seatId = findSeatId(line)
        if highestId == 0 or highestId < seatId:
            highestId = seatId
    print(highestId)

def partTwo(lines):
    seatIds = []
    for line in lines:
        seatIds.append(findSeatId(line))

    swapped = True

    while(swapped):
        swapped = False
        for i in range(len(seatIds) - 1):
            if seatIds[i] > seatIds[i+1]:
                temp = seatIds[i]
                seatIds[i] = seatIds[i+1]
                seatIds[i+1] = temp
                swapped = True

    for i in range(len(seatIds)):
        if seatIds[i]+2 == seatIds[i+1]:
            print(seatIds[i]+1)
            break

partOne(lines)
partTwo(lines)
