#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <conio.h>
#include <ctype.h>
#include "funciones.h"

void setearestados(eUsuarios estad_usuarios [],eProductos estad_productos[])
{
    int i;

        for(i=0;i<MAX_USUARIOS;i++)
        {
            estad_usuarios[i].Estad_Usuarios = 0;
            estad_usuarios[i].totalcalificacion = 0;
        }

        for(i=0;i<MAX_PRODUCTOS;i++)
        {
            estad_productos[i].Estad_Prod = 0;
            estad_productos[i].calificaciones = 0;
        }
}

int lugarlibreUsuario(eUsuarios espacio [])
{
    int i;
    int bandera=0;

    int devuelve;

        for(i=0;i<MAX_USUARIOS;i++)
        {
            if(espacio[i].Estad_Usuarios == 0)
            {
                devuelve = i;
                bandera = 1;
                break;
            }
        }

    if(bandera == 0)
    {
        devuelve = -1;
    }

    return devuelve;
}

int buscoIDUsuario(eUsuarios usuario [], int IDbuscar)
{
    int i;

    int bandera = 0;

    int devuelve;

        for(i=0;i<MAX_USUARIOS;i++)
        {
            if(IDbuscar == usuario[i].ID_Usuarios && usuario[i].Estad_Usuarios == 1)
            {
                devuelve = i;
                bandera = 1;
                break;
            }
        }

    if(bandera == 0)
    {
        devuelve = -1;
    }

    return devuelve;
}

int lugarlibreProducto(eProductos producto [])
{
    int devuelve;

    int bandera;

    int i;

        for(i=0;i<MAX_PRODUCTOS;i++)
        {
            if(producto[i].Estad_Prod == 0)
            {
                devuelve = i;
                bandera = 1;
                break;
            }
        }

    if(bandera == 0)
    {
        devuelve = -1;
    }

    return devuelve;
}

int buscoIDProducto(eProductos producto [], int IDbuscar)
{
     int i;

    int bandera = 0;

    int devuelve;

        for(i=0;i<MAX_PRODUCTOS;i++)
        {
            if(IDbuscar == producto[i].ID_Producto && producto[i].Estad_Prod == 1)
            {
                devuelve = i;
                bandera = 1;
                break;
            }
        }

    if(bandera == 0)
    {
        devuelve = -1;
    }

    return devuelve;
}

void cargaUsuario(eUsuarios usuario [],eProductos productos [])
{
    int posicion;
    int bandera=0;


    if(bandera == 0)
    {
        setearestados(usuario,productos);
        bandera = 1;
    }
        system("cls");
        posicion = lugarlibreUsuario(usuario);

    if(posicion != -1)
    {
        printf("Ingrese el nombre del usuario: ");
        fflush(stdin);
        gets(usuario[posicion].Nombre);

        printf("Ingrese su contrasena: ");
        fflush(stdin);
        gets(usuario[posicion].Contrasena);

        usuario[posicion].ID_Usuarios = (posicion+1000)*2;

        usuario[posicion].Estad_Usuarios = 1;


        printf("La carga fue exitosa:\n");
        printf("ID: %d\n",usuario[posicion].ID_Usuarios);
        printf("Nombre: %s\n",usuario[posicion].Nombre);
        printf("Contrasena: %s\n\n",usuario[posicion].Contrasena);
        system("pause");
    }
    else
    {
        printf("\nNo hay espacio para realizar la carga.\n\n");
        system("pause");
    }

}

void modificarUsuario(eUsuarios usuario [])
{
    int posicion;
    int IDbusqueda;

    int opcion;

    char auxNomre[50];
    char auxContra[50];

        system("cls");

        printf("Ingrese el ID a buscar: ");
        scanf("%d",&IDbusqueda);


            posicion = buscoIDUsuario(usuario,IDbusqueda);

        if(posicion != -1)
        {
            printf("\nID: %d\n",usuario[posicion].ID_Usuarios);
            printf("Usuario: %s\n",usuario[posicion].Nombre);
            printf("Contrasena: %s\n\n",usuario[posicion].Contrasena);

            printf("1. Cambiar nombre\n");
            printf("2. Cambiar contrasena\n");
            printf("3. Cambiar nombre y contrasena\n");
            printf("Ingrese la opcion deseada: ");
            scanf("%d",&opcion);

                switch(opcion)
                {
                    case 1:
                        system("cls");

                            printf("ingrese nuevo nombre: ");
                            fflush(stdin);
                            gets(auxNomre);

                                strcpy(usuario[posicion].Nombre,auxNomre);

                            printf("\nID: %d\n",usuario[posicion].ID_Usuarios);
                            printf("Nuevo nombre Usuario: %s\n",usuario[posicion].Nombre);
                        system("pause");
                        break;
                    case 2:
                        system("cls");

                            printf("ingrese nueva contrasena: ");
                            fflush(stdin);
                            gets(auxContra);

                                strcpy(usuario[posicion].Contrasena,auxContra);

                            printf("\nID: %d\n",usuario[posicion].ID_Usuarios);
                            printf("Usuario: %s\n",usuario[posicion].Nombre);
                            printf("Nueva contrasena: %s\n",usuario[posicion].Contrasena);
                        system("pause");
                        break;
                    case 3:
                        system("cls");

                            printf("ingrese nuevo nombre: ");
                            fflush(stdin);
                            gets(auxNomre);
                            printf("ingrese nueva contrasena: ");
                            fflush(stdin);
                            gets(auxContra);

                                strcpy(usuario[posicion].Nombre,auxNomre);
                                strcpy(usuario[posicion].Contrasena,auxContra);

                            printf("\nID: %d\n",usuario[posicion].ID_Usuarios);
                            printf("Nuevo nombre Usuario: %s\n",usuario[posicion].Nombre);
                            printf("Nueva contrasena: %s\n",usuario[posicion].Contrasena);
                        system("pause");
                        break;
                    default:
                        while(opcion < 1 || opcion > 3)
                        {
                            printf("\nLa opcion ingresada es invalida.\nReingrese: ");
                            scanf("%d",&opcion);
                        }
                }
        }
        else
        {
            printf("\nNo se a encontrado a ningun usuario con ese ID.\n\n");
            system("pause");
        }
}

void mostrarUsuarios(eUsuarios usuarios [])
{
    int i;

        system("cls");

        printf("USUARIOS\n");
        printf("\nID       NOMBRE\n\n");
        for(i=0;i<MAX_USUARIOS;i++)
        {
            if(usuarios[i].Estad_Usuarios == 1)
            {
                printf("%d       %s\n\n",usuarios[i].ID_Usuarios,usuarios[i].Nombre);
            }
        }

        system("pause");
}

void publicarProducto(eUsuarios usuario[], eProductos producto[])
{
    int IDbusqueda;

    int verificador;

    int posicion;

        system("cls");

        printf("Ingrese el ID del usuario: ");
        scanf("%d",&IDbusqueda);

            verificador = buscoIDUsuario(usuario,IDbusqueda);

        if(verificador != -1)
        {
            system("cls");

            posicion = lugarlibreProducto(producto);

            if(posicion != -1)
            {
                printf("Ingrese nombre producto: ");
                fflush(stdin);
                gets(producto[posicion].Nombre);
                printf("Ingrese precio: ");
                scanf("%f",&producto[posicion].Precio);
                printf("Ingrese cantidad: ");
                fflush(stdin);
                scanf("%d",&producto[posicion].Stock);

                producto[posicion].Vendidos =  0;

                producto[posicion].ID_Usuarios = IDbusqueda;

                producto[posicion].ID_Producto = (posicion*1000)+2;

                producto[posicion].Estad_Prod = 1;


            }
            else
            {
                system("cls");
                printf("no hay lugar para cargar mas productos.\n\n");
                system("pause");
            }

        }
        else
        {
            system("cls");
            printf("el ID ingresado no corresponde a ningun usuario registrado.\n\n");
            system("pause");
        }

}

void modificarProducto(eUsuarios usuario[], eProductos producto[])
{
    int i;

    int bandera = 0;

    int IDbuscar;

    int verificador;

    float nuevoPrecio;
    int nuevoStock;

        system("cls");

            printf("ingrese el ID del usuario propietario del producto: ");
            scanf("%d",&IDbuscar);

            verificador = buscoIDUsuario(usuario,IDbuscar);

        if(verificador != -1)
        {
            system("cls");
                printf("ID\t\tNOMBRE\t\tPRECIO\t\tVENDIDOS\t\tSTOCK\n\n");
            for(i=0;i<MAX_PRODUCTOS;i++)
            {
                if((usuario[verificador].ID_Usuarios == producto[i].ID_Usuarios) && producto[i].Estad_Prod == 1)
                {
                    printf("%d\t\t%s\t\t%.2f\t\t%d\t\t%d\n\n",producto[i].ID_Producto,producto[i].Nombre,producto[i].Precio,producto[i].Vendidos,producto[i].Stock);
                    bandera = 1;
                }
            }

            if(bandera != 0)
            {

                printf("ingrese el ID del producto: ");
                scanf("%d",&IDbuscar);

                verificador = buscoIDProducto(producto,IDbuscar);

                if(verificador != -1)
                {
                    system("cls");

                        printf("ID\t\tNOMBRE\t\tPRECIO\t\tSTOCK\n\n");
                        printf("%d\t\t%s\t\t%.2f\t\t%d\n\n",producto[verificador].ID_Producto,producto[verificador].Nombre,producto[verificador].Precio,producto[verificador].Stock);

                        printf("ingrese el nuevo precio: ");
                        scanf("%f",&nuevoPrecio);
                        printf("ingrese el nuevo stock: ");
                        scanf("%d",&nuevoStock);

                        producto[verificador].Precio = nuevoPrecio;
                        producto[verificador].Stock = nuevoStock;

                        printf("ID: %d\n",producto[verificador].ID_Producto);
                        printf("PRODUCTO: %s\n",producto[verificador].Nombre);
                        printf("NUEVO PRECIO: %.2f\n",producto[verificador].Precio);
                        printf("NUEVO STOCK: %d\n",producto[verificador].Stock);
                        printf("VENDIDOS: %d\n\n",producto[verificador].Vendidos);
                        system("pause");
                }
                else
                {
                    system("cls");
                    printf("El ID del producto ingresado no corresponde con ninguno de este usuario.\n");
                    system("pause");
                }

            }
            else
            {
                system("cls");
                printf("Este usuario no dispone de ningun producto a la venta.\n");
                system("pause");
            }
        }
        else
        {
            system("cls");
            printf("el ID ingresado no corresponde a ningun usuario registrado.\n");
            system("pause");
        }
}

void cancelarPublicaxion(eUsuarios usuario[], eProductos producto[])
{
    int i;

    int bandera = 0;

    int IDbuscar;

    int verificador;

    char seguir;

        system("cls");

            printf("ingrese el ID del usuario propietario del producto: ");
            scanf("%d",&IDbuscar);

            verificador = buscoIDUsuario(usuario,IDbuscar);

        if(verificador != -1)
        {
            system("cls");
                printf("ID\t\tNOMBRE\t\tPRECIO\t\tVENDIDOS\t\tSTOCK\n\n");
            for(i=0;i<MAX_PRODUCTOS;i++)
            {
                if((usuario[verificador].ID_Usuarios == producto[i].ID_Usuarios) && producto[i].Estad_Prod == 1)
                {
                    printf("%d\t\t%s\t\t%.2f\t\t%d\t\t%d\n\n",producto[i].ID_Producto,producto[i].Nombre,producto[i].Precio,producto[i].Vendidos,producto[i].Stock);
                    bandera = 1;
                }
            }

            if(bandera != 0)
            {

                printf("ingrese el ID del producto: ");
                scanf("%d",&IDbuscar);

                verificador = buscoIDProducto(producto,IDbuscar);

                if(verificador != -1)
                {
                    system("cls");

                        printf("ID\t\tNOMBRE\t\tPRECIO\t\tSTOCK\n\n");
                        printf("%d\t\t%s\t\t%.2f\t\t%d\n\n",producto[verificador].ID_Producto,producto[verificador].Nombre,producto[verificador].Precio,producto[verificador].Stock);

                           printf("Desea dar de baja este producto? (s/n)\nIngrrese su respuesta: ");
                           seguir = tolower(getch());

                        if(seguir == 's')
                        {
                            producto[verificador].Estad_Prod = 0;
                            printf("\nLa baja fue exitosa.\n\n");
                            system("pause");
                        }
                        else
                        {
                            printf("\nSe a cancelado la baja.\n\n");
                            system("pause");
                        }
                }
                else
                {
                    system("cls");
                    printf("El ID del producto ingresado no corresponde con ninguno de este usuario.\n");
                    system("pause");
                }

            }
            else
            {
                system("cls");
                printf("Este usuario no dispone de ningun producto a la venta.\n");
                system("pause");
            }
        }
        else
        {
            system("cls");
            printf("el ID ingresado no corresponde a ningun usuario registrado.\n");
            system("pause");
        }
}

void comprarProducto(eUsuarios usuario[], eProductos producto[])
{
    int usuariobuscar;
    int productobuscar;

    int posicionusuario;
    int posicionproducto;

    float auxiliar;

    int i;

    int bandera = 0;

    char seguir;

        system("cls");

            printf("Ingrese el ID del usuario: ");
            scanf("%d",&usuariobuscar);

            posicionusuario = buscoIDUsuario(usuario,usuariobuscar);

            if(posicionusuario != -1)
            {
                system("cls");

                    printf("ID\t\tNOMBRE\t\tPRECIO\t\tVENDIDOS\t\tSTOCK\n\n");
                    for(i=0;i<MAX_PRODUCTOS;i++)
                    {
                        if((usuario[posicionusuario].ID_Usuarios == producto[i].ID_Usuarios) && producto[i].Estad_Prod == 1)
                        {
                            printf("%d\t\t%s\t\t%.2f\t\t%d\t\t%d\n,",producto[i].ID_Producto,producto[i].Nombre,producto[i].Precio,producto[i].Vendidos,producto[i].Stock);
                            if(bandera == 0)
                            { bandera = 1; }
                        }
                    }

                if(bandera != 0)
                {
                    printf("\nIngrese el ID del producto: ");
                    scanf("%d",&productobuscar);

                        posicionproducto = buscoIDProducto(producto,productobuscar);

                        if(posicionproducto != -1)
                        {
                           if(producto[posicionproducto].Stock != 0)
                           {
                                    system("cls");

                                printf("ID\t\tNOMBRE\t\tPRECIO\t\tSTOCK\n\n");
                                printf("%d\t\t%s\t\t%.2f\t\t%d\n",producto[posicionproducto].ID_Producto,producto[posicionproducto].Nombre,producto[posicionproducto].Precio,producto[posicionproducto].Stock);

                                printf("\nDesea comprar el producto? (/)\nIngrese su respuesta: ");
                                seguir = tolower(getch());

                                if(seguir == 's')
                                {
                                    producto[posicionproducto].Vendidos += 1;
                                    producto[posicionproducto].Stock -= 1;

                                    if(producto[posicionproducto].calificaciones != 0)
                                    {
                                        printf("ingrese una calificacion para el usuario (1-10): ");
                                        scanf("%f",&auxiliar);
                                        printf("\n(Se aceptan numeros con decimales)");

                                        while(auxiliar < 1 || auxiliar > 10)
                                        {
                                            printf("Calificacion invalida.\nReingrese: ");
                                            scanf("%f",&auxiliar);
                                        }

                                        producto[posicionproducto].calificaciones = (producto[posicionproducto].calificaciones + auxiliar)/2;
                                        system("cls");
                                        printf("\nLa venta fue exitosa.\n\n");
                                        system("pause");
                                    }
                                    else
                                    {
                                        printf("ingrese una calificacion para el usuario (1-10): ");
                                        scanf("%f",&producto[posicionproducto].calificaciones);
                                        printf("\n(Se aceptan numeros con decimales)");

                                        while(producto[posicionproducto].calificaciones < 1 || producto[posicionproducto].calificaciones > 10)
                                        {
                                            printf("Calificacion invalida.\nReingrese: ");
                                            scanf("%f",&producto[posicionproducto].calificaciones);
                                        }

                                        system("cls");
                                        printf("\nLa venta fue exitosa.\n\n");
                                        system("pause");
                                    }
                                }
                                else
                                {
                                    system("cls");
                                    printf("Se cancelo la operacion.\n\n");
                                    system("pause");
                                }
                           }
                           else
                           {
                               system("cls");
                               printf("\nEl producto seleccionado no dispone de stock para la compra.\n\n");
                               system("pause");
                           }
                        }
                        else
                        {
                            system("cls");
                            printf("El ID ingresado no coincide con ningun producto.\n\n");
                            system("pause");
                        }

                }
                else
                {
                    system("cls");
                    printf("El usuario no dispone de productos a la venta.\n\n");
                    system("pause");
                }
                printf("\n\n");
                system("pause");
            }
            else
            {
                printf("\nNo se a encontrado ningun usuario con este ID.\n\n");
                system("pause");
            }



}

void bajausuario(eUsuarios usuario[],eProductos producto[])
{
    int i;

    int IDbuscar;

    int verificador;

    char seguir;

        system("cls");

            printf("ingrese el ID del usuario: ");
            scanf("%d",&IDbuscar);

            verificador = buscoIDUsuario(usuario,IDbuscar);

        if(verificador != -1)
        {
            system("cls");
            printf("ID\t\tUSUARIO\n\n");
            printf("%d\t\t%s\n\n",usuario[verificador].ID_Usuarios,usuario[verificador].Nombre);

            printf("Desea dar de baja al usuario?\n(En caso de darse de baja se borraran todos sus productos publicados)\n");
            printf("Ingrese su respuesta (s/n): ");
            fflush(stdin);
            seguir = tolower(getch());


                if(seguir == 's')
                {
                    system("cls");
                    for(i=0;i<MAX_PRODUCTOS;i++)
                    {
                        if(usuario[verificador].ID_Usuarios == producto[i].ID_Usuarios)
                        {
                            producto[i].Estad_Prod = 0;
                        }
                    }
                    usuario[verificador].Estad_Usuarios = 0;

                    printf("La baja a sido efectiva.\n\n");
                    system("pause");

                }
                else
                {
                    system("cls");
                    printf("Se a cancelado la operacion.\n\n");
                    system("pause");
                }
        }
        else
        {
            printf("\nNo se a encontrado ningun usuario con este ID.\n\n");
            system("pause");
        }
}

void publicacionesUsuario(eUsuarios usuario[], eProductos productos[])
{
    int i;

    int IDbusqueda;

    int verificador;

    int bandera = 0;

            system("cls");

            printf("Ingrese el ID del usuario: ");
            scanf("%d",&IDbusqueda);

            verificador = buscoIDUsuario(usuario,IDbusqueda);

            if(verificador != -1)
            {
                printf("\nID\t\tUSUARIO\n\n");
                printf("%d\t\t%s\n",usuario[verificador].ID_Usuarios,usuario[verificador].Nombre);
                printf("------------------------------------------------\n");
                printf("PRODUCTOS\n");
                printf("ID\t\tNOMBRE\t\tPRECIO\t\tVENDIDOS\t\tSTOCK\n\n");

                    for(i=0;i<MAX_PRODUCTOS;i++)
                    {
                        if(usuario[verificador].ID_Usuarios == productos[i].ID_Usuarios)
                         {
                            printf("%d\t\t%s\t\t%.2f\t\t%d\t\t%d\n",productos[i].ID_Producto,productos[i].Nombre,productos[i].Precio,productos[i].Vendidos,productos[i].Stock);
                            printf("-----------------------------------------------------------\n");
                            if(bandera == 0)
                            {  bandera = 1; }
                         }
                    }

                if(bandera == 0)
                {
                    system("cls");
                    printf("\nEste usuario no tiene ningun producto registrado.\n\n");
                    system("pause");
                }
                printf("\n\n");
                system("pause");
            }
            else
            {
                printf("\nEl ID ingresado no corresponde con ningun usuario registrado.\n\n");
                system("pause");
            }
}

void mostrarPublicaciones(eUsuarios usuarios[], eProductos productos[])
{
    int i , j;

    int bandera = 0;

        system("cls");

            printf("ID\t\tNOMBRE\t\tPRECIO\t\tvVENDIDOS\t\tSTOCK\t\tUSUARIOS\n\n");

                for(i= 0;i<MAX_PRODUCTOS;i++)
                {
                    if(productos[i].Estad_Prod == 1)
                    {
                        for(j=0;j<MAX_USUARIOS;j++)
                        {
                            if(productos[i].ID_Usuarios == usuarios[j].ID_Usuarios)
                            {
                                printf("%d\t\t%s\t\t%.2f\t\t%d\t\t%d\t\t%s\n",productos[i].ID_Producto,productos[i].Nombre,productos[i].Precio,productos[i].Vendidos,productos[i].Stock,usuarios[j].Nombre);
                                printf("----------------------------------------------------------------------------\n");
                            }
                        }
                        if(bandera == 0)
                        { bandera = 1; }
                    }
                }

        if(bandera == 0)
        {
            system("cls");
            printf("\nNo hay ningun producto registrado.\n\n");
            system("pause");
        }

        if(bandera != 0)
        {
            printf("\n\n");
            system("pause");
        }
}



