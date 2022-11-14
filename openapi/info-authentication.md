
## Headers

Para un mejor uso de nuestra API, debes de tomar en cuenta que cada request que se haga, se recibe los siguientes headers.

| Clave  | Valor |
|-------|-------|
| Authorization | Token | 
| Content-Type | application/json |
| environment | ni, dev |
| Accept-Language | es, en |

## Autenticación.

Para obtener el valor del token necesitas realizar un POST request hacia https://api.tizo.co/api/v1/auth/login con el siguiente body: <br>
{<br>
"username": "your_username",<br>
"password": "your_password",<br>
"typeUser": "store_api"<br>
}<br>
Una vez logueado, tus credenciales tienen acceso durante 7 días en nuestra plataforma, por lo que debes refrescar el token una vez ya expirado. Si no tienes ninguno de estos datos, por favor contáctenos. 