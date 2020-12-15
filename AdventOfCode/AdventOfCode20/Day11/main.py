import copy

def surroundingSeatsAreEmpty(seatMap, row, column):
    if row+1 < len(seatMap) and seatMap[row+1][column] == "#":
        return False
    if row > 0 and seatMap[row-1][column] == "#":
        return False
    if column+1 < len(seatMap[row]) and seatMap[row][column+1] == "#":
        return False
    if column > 0 and seatMap[row][column-1] == "#":
        return False
    if row+1 < len(seatMap) and column+1 < len(seatMap[i]) and seatMap[row+1][column+1] == "#":
        return False
    if row > 0 and column > 0 and seatMap[row-1][column-1] == "#":
        return False
    if row > 0 and column+1 < len(seatMap[i]) and seatMap[row-1][column+1] == "#":
        return False
    if column > 0 and row+1 < len(seatMap) and seatMap[row+1][column-1] == "#":
        return False
    return True

def countSurroundingSeats(seatMap, row, column):
    count = 0
    if row+1 < len(seatMap) and seatMap[row+1][column] == "#":
        count = count + 1
    if row > 0 and seatMap[row-1][column] == "#":
        count = count + 1
    if column+1 < len(seatMap[row]) and seatMap[row][column+1] == "#":
        count = count + 1
    if column > 0 and seatMap[row][column-1] == "#":
        count = count + 1
    if row+1 < len(seatMap) and column+1 < len(seatMap[i]) and seatMap[row+1][column+1] == "#":
        count = count + 1
    if row > 0 and column > 0 and seatMap[row-1][column-1] == "#":
        count = count + 1
    if row > 0 and column+1 < len(seatMap[i]) and seatMap[row-1][column+1] == "#":
        count = count + 1
    if column > 0 and row+1 < len(seatMap) and seatMap[row+1][column-1] == "#":
        count = count + 1
    return count

file = open("input.txt", "r")
lines = file.read().splitlines()

seatMap = []

for line in lines:
    seatLine =[]
    for seat in line:
        seatLine.append(seat)
    seatMap.append(seatLine)

changed = True

while changed:
    changed = False
    newSeatMap = []
    for line in seatMap:
        newSeatLine =[]
        for seat in line:
            newSeatLine.append(seat)
        newSeatMap.append(newSeatLine)
    for i in range(len(seatMap)):
        for j in range(len(seatMap[i])):
            if seatMap[i][j] == "L":
                if surroundingSeatsAreEmpty(seatMap, i, j):
                    newSeatMap[i][j] = "#"
                    changed = True
            if seatMap[i][j] == "#":
                if countSurroundingSeats(seatMap, i, j) >= 4:
                    newSeatMap[i][j] = "L"
                    changed = True
    seatMap = []
    for line in newSeatMap:
        seatLine =[]
        for seat in line:
            seatLine.append(seat)
        seatMap.append(seatLine)
count = 0
for i in range(len(seatMap)):
    for j in range(len(seatMap[i])):
        if seatMap[i][j] == "#":
            count=count+1
print(count)
