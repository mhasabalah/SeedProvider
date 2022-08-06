from helpers import *

directory = "docs"
Chech_directory(directory)

while True:
    result = input("Enter namespace:")
    if result == '' or result[-1] != "s": 
        print("Please enter a namespace with an s at the end")
    else: break

name = input("Enter name:")
namespace = result[0].upper() + result[1:]

data = ChangeSeedProvider(namespace, name)

try:
    with open(f"{directory}/{namespace}SeedProvider.cs", 'w',encoding="utf-8") as f:
        f.write(data)
except FileNotFoundError:
    print(f"The '{directory}' directory does not exist")