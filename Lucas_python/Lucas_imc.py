import os, sys

nome = raw_input("insira seu Nome:")
peso = raw_input("insira seu Peso:")
altura = raw_input("insira sua Altura:")

imc= peso/(altura*altura)

if (imc < 17):
    print("senhor(a){0}{1} o seu imc está {2} portanto o senhor(a) se encontra muito abaixo do peso", nome , imc))
elif (imc >= 17 and imc < 18.5):
    print("senhor(a){0}{1} o seu imc está {2} portanto o senhor(a) se encontra abaixo do peso", nome , imc))
elif (imc >= 18.5 and imc < 25):
    print("senhor(a){0}{1} o seu imc está {2} portanto o senhor(a) se encontra normal", nome , imc))
elif (imc) >= 25 and imc < 30):
    print("senhor(a){0}{1} o seu imc está {2} portanto o senhor(a) se encontra acima do peso", nome , imc))
elif (imc >= 30 and imc < 35):
    print("senhor(a){0}{1} o seu imc está {2} portanto o senhor(a) se encontra em obesidade 1", nome , imc))
elif (imc >= 35 and i1imc < 40):
    print("senhor(a){0}{1} o seu imc está {2} portanto o senhor(a) se encontra em obesidade 2", nome , imc))
else:
    print("senhor(a){0}{1} o seu imc está {2} portanto o senhor(a) se encontra em obesidade 3 (Mórbida)", nome , imc))