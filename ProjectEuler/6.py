totalSquares = 0
basicTotal = 0

for i in range(1, 101):
  totalSquares = totalSquares + (i*i)
  basicTotal = basicTotal + i

squareTotal = basicTotal*basicTotal

print(squareTotal - totalSquares)
