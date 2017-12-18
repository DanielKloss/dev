puzzleInput = [11, 11, 13, 7, 0, 15, 5, 5, 4, 4, 1, 1, 7, 1, 15, 11]#puzzleInput = [0,2,7,0]
savedStates = []savedStates.append(str(puzzleInput))
noRepeatition = Truecounter = 0
while noRepeatition:  maxNumber = max(puzzleInput)  currentIndex = puzzleInput.index(maxNumber)  blocksToRedistrubute = puzzleInput[currentIndex]  puzzleInput[currentIndex] = 0    for b in range(0, blocksToRedistrubute):    currentIndex += 1        if currentIndex >= len(puzzleInput):      currentIndex = 0            puzzleInput[currentIndex] += 1    blocksToRedistrubute -= 1    counter += 1    if any(str(puzzleInput) in s for s in savedStates):    noRepeatition = False  else:    savedStates.append(str(puzzleInput))      print(counter) 
