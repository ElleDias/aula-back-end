Console.WriteLine(@"
+--------------------------------------+
|            SEJA BEM-VINDO            |
|                                      |
|             AO PROGRAMA              |
+--------------------------------------+
");
# Função para intercalar dois vetores
def intercalar_vetores(vetor1, vetor2);
    vetor_intercalado = []
    for i in range(len(vetor1)){
      
        vetor_intercalado.append(vetor1[i]);
        vetor_intercalado.append(vetor2[i]);
    return vetor_intercalado;   }
   

// Carregar os dois vetores
vetor1 = []
vetor2 = []

print("Digite 10 elementos para o primeiro vetor:")
for i in range(10){
     elemento = float(input(f"Elemento {i+1}: "));
    vetor1.append(elemento);

}
   
print("\nDigite 10 elementos para o segundo vetor:")
for i in range(10){
      elemento = float(input(f"Elemento {i+1}: "));
    vetor2.append(elemento);  
}


// Intercalar os vetores
vetor_intercalado = intercalar_vetores(vetor1, vetor2);

// Imprimir o vetor intercalado
print("\nVetor intercalado:");
print(vetor_intercalado);