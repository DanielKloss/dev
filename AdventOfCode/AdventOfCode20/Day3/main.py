def readFile():
    file = open("input.txt", "r")
    fileLines = file.read()
    lines = fileLines.split('\n')

    slopeMap = []

    for line in lines:
        slopeLine = []
        for character in line:
            slopeLine.append(character)
        slopeMap.append(slopeLine)

    return slopeMap

def findTrees(directions):
    treeCounts = []
    slope = readFile()

    for direction in directions:
        treeCount = 0
        currentCoordinate = [0,0]
        while currentCoordinate[0] < len(slope)-1:
            if slope[currentCoordinate[0]][currentCoordinate[1]] == '#':
                treeCount = treeCount + 1

            currentCoordinate = [currentCoordinate[0]+direction[0], currentCoordinate[1]+direction[1]]

            if currentCoordinate[1] > len(slope[0])-1:
                difference = currentCoordinate[1] - len(slope[0])
                currentCoordinate[1] = difference

        treeCounts.append(treeCount)

    answer = 0
    for count in treeCounts:
        if answer == 0:
            answer = count
        else:
            answer = answer * count
    return answer

print(findTrees([[1,1], [1,3], [1,5], [1,7], [2,1]]))
