#range - 273025-767253
testPassword = 273025
count = 0

while int(testPassword) <= 767253:
  doubleFound = False
  decrementFound = False
  currentDigtPosition = 0
  while currentDigtPosition < len(str(testPassword)):
    if currentDigtPosition-1 >= 0 and str(testPassword)[currentDigtPosition] < str(testPassword)[currentDigtPosition-1]:
      decrementFound = True
      break
    if currentDigtPosition+1 < len(str(testPassword)) and str(testPassword)[currentDigtPosition] == str(testPassword)[currentDigtPosition+1]:
        counter = 1
        searchingDigitPosition = currentDigtPosition+1
        while searchingDigitPosition < len(str(testPassword)) and str(testPassword)[currentDigtPosition] == str(testPassword)[searchingDigitPosition]:
          counter = counter+1
          searchingDigitPosition = searchingDigitPosition+1
        if counter == 2:
          doubleFound = True
        currentDigtPosition = searchingDigitPosition
    else:
        currentDigtPosition = currentDigtPosition+1

  if doubleFound == True and decrementFound == False:
    print("found one! " + str(testPassword))
    count = count + 1
  testPassword = int(testPassword) + 1

print(count)
