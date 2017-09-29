#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <conio.h>
#include <time.h>
#include "funciones.h"


int main()
{
    int opcion;
    char seguir = 's';

    eUsuarios usuarios[MAX_USUARIOS];
    eProductos productos[MAX_PRODUCTOS];



    do
    {
        system("cls");
        printf("1. ALTA DE USUARIO\n");
        printf("2. MODIFICAR DATOS DEL USUARIO\n");
        printf("3. BAJA DEL USUARIO\n");
        printf("4. PUBLICAR PRODUCTO\n");
        printf("5. MODIFICAR PUBLICACION\n");
        printf("6. CANCELAR PUBLICACION\n");
        printf("7. COMPRAR PRODUCTO\n");
        printf("8. LISTAR PUBLICACIONES DE USUARIO\n");
        printf("9. LISTAR PUBLICACIONES\n");
        printf("10. LISTAR USUARIOS\n");
        printf("0. SALIR\n");
        printf("\nIngrese la opcion deseada:  ");
        scanf("%d",&opcion);

        switch(opcion)
        {
            case 1:
                cargaUsuario(usuarios,productos);
                break;
            case 2:
                modificarUsuario(usuarios);
                break;
            case 3:
                break;
            case 4:
                publicarProducto(usuarios,productos);
                break;
            case 5:
                modificarProducto(usuarios,productos);
                break;
            case 6:
                break;
            case 7:
                break;
            case 8:
                break;
            case 9:
                break;
            case 10:
                mostrarUsuarios(usuarios);
                break;
            case 0:
            seguir = 'n';
                break;
            default:
                    printf("\nOpcion incorrecta, por favor reingrese la opcion deseada.\n\n");
                    system("pause");
                    system("cls");

        }

    }while(seguir == 's');

    return 0;
}
