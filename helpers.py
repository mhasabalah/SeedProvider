import os
import uuid


def ChangeSeedProvider(namespace, name):
    fin = open("TestsSeedProvider.cs", "rt", encoding="utf-8")

    data = fin.read()
    data = data.replace('Tests', namespace)
    data = data.replace('NameOfSecondLanguage',  camel_case_split(namespace))
    data = data.replace('الاسم',  name)



    data = data.replace('ParentChildId',str(uuid.uuid4()))
    data = data.replace('ChildId-1', str(uuid.uuid4()))
    data = data.replace('ChildId-2', str(uuid.uuid4()))
    data = data.replace('ChildId-3', str(uuid.uuid4()))
    data = data.replace('ChildId-4', str(uuid.uuid4()))
    data = data.replace('ChildId-5', str(uuid.uuid4()))

    fin.close()
    return data

def Chech_directory(dir):
    if not os.path.exists(dir):
        try:
            os.mkdir(dir)
        except OSError as error:
            print(error)


def camel_case_split(str):
    words = [[str[0]]]

    for c in str[1:]:
        if words[-1][-1].islower() and c.isupper():
            words.append(list(c))
        else:
            words[-1].append(c)
    output =[''.join(word) for word in words] 
    return ' '.join(output)


def question():
    i = 0
    while i < 2:
        answer = input("Question? (yes or no)")
        if any(answer.lower() == f for f in ["yes", 'y', '1', 'ye']):
            print("Yes")
            break
        elif any(answer.lower() == f for f in ['no', 'n', '0']):
            print("No")
            break
        else:
            i += 1
            if i < 2:
                print('Please enter yes or no')
            else:
                print("Nothing done")


# try:
#     os.remove(directory)
#     print("% s removed successfully" % "{directory}")
# except OSError as error:
#     print(error)
#     print("File path can not be removed")
