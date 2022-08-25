from operator import truediv

# Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

print("Enter first number ")
a = int(input())
count = 1
while count <= a:
    if(count % 2 == 0):
        print(count)  
    count += 1
    