def readFile():
    file = open("input.txt", "r")
    fileLines = file.read()
    lines = fileLines.split('\n')

    passports = []
    currentPassport = {}

    for line in lines:
        if line == "":
            passports.append(currentPassport)
            currentPassport = {}
        else:
            credentials = line.split(' ')
            for credential in credentials:
                title = credential.split(':')[0]
                detail = credential.split(':')[1]
                currentPassport[title] = detail

    return passports

def checkPassports():
    validPassports = 0
    passports = readFile()

    for passport in passports:
        if "byr" not in  passport or "iyr" not in passport or "eyr" not in passport or "hgt" not in passport or "hcl" not in passport or "ecl" not in passport or "pid" not in passport:
            continue
        if len(passport["byr"]) != 4 or int(passport["byr"]) < 1920 or int(passport["byr"]) > 2020:
            continue
        if len(passport["iyr"]) != 4 or int(passport["iyr"]) < 2010 or int(passport["iyr"]) > 2020:
            continue
        if len(passport["eyr"]) != 4 or int(passport["eyr"]) < 2020 or int(passport["eyr"]) > 2030:
            continue
        if "cm" not in passport["hgt"] and "in" not in passport["hgt"]:
            continue
        elif "cm" in passport["hgt"]:
            if int(passport["hgt"].split("cm")[0]) < 150 or int(passport["hgt"].split("cm")[0]) > 193:
                continue
        elif "in" in passport["hgt"]:
            if int(passport["hgt"].split("in")[0]) < 59 or int(passport["hgt"].split("in")[0]) > 76:
                continue
        if passport["hcl"][0] != '#' or len(passport["hcl"]) != 7:
            continue
        invalid = False
        for i in range(1, len(passport["hcl"])):
            if passport["hcl"][i] != "0" and passport["hcl"][i] != "1" and passport["hcl"][i] != "2" and passport["hcl"][i] != "3" and passport["hcl"][i] != "4" and passport["hcl"][i] != "5" and passport["hcl"][i] != "6" and passport["hcl"][i] != "7" and passport["hcl"][i] != "8" and passport["hcl"][i] != "9" and passport["hcl"][i] != "a" and passport["hcl"][i] != "b" and passport["hcl"][i] != "c" and passport["hcl"][i] != "d" and passport["hcl"][i] != "e" and passport["hcl"][i] != "f":
                invalid = True
                break
        if invalid == True:
            continue
        if passport["ecl"] != "amb" and passport["ecl"] != "blu" and passport["ecl"] != "brn" and passport["ecl"] != "gry" and passport["ecl"] != "grn" and passport["ecl"] != "hzl" and passport["ecl"] != "oth":
            continue
        if len(passport["pid"]) != 9:
            continue

        validPassports = validPassports + 1

    print(validPassports)

checkPassports()
