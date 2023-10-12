# N5APAC

Para registrar la inyección de dependencias se uso el método AddScope de .Net , ya que la dependencia dura el ciclo de vida de la request.

De usar otro tipo de dependencia como singleton se crearía una instancia única de dependencia en toda la aplicación, eso implicaría que todas las request comparten una misma instancia de dependencia y puede generar problemas. Si fuera transient se crearía una instancia en cada solicitud pero persistiría.
