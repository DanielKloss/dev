puzzleInput = 325489noSquareRootFound = TruesquareRoot = 1
while noSquareRootFound:  square = squareRoot * squareRoot
  if square > puzzleInput:    noSquareRootFound = False  else:    squareRoot += 2
layerNumber = (squareRoot + 1) / 2
maxSquare = (2*layerNumber - 1) ** 2
if (puzzleInput>=maxSquare-layerNumber):  print(layerNumber+ maxSquare-puzzleInput)elif(puzzleInput>=maxSquare-2*layerNumber):  print(layerNumber+ maxSquare-layerNumber-puzzleInput)elif(puzzleInput>=maxSquare-3*layerNumber):  print(layerNumber+ maxSquare-2*layerNumber-puzzleInput)else:  print(layerNumber+ maxSquare-3*layerNumber-puzzleInput)
