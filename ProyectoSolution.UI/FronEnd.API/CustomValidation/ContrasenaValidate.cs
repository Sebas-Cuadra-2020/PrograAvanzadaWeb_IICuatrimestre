﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace FronEnd.API.CustomValidation
{
    public class ContrasenaValidate : Attribute, IModelValidator//Acceder a la interfaz IModelValidator

    {

        public string ErrorMessage { get; set; }

        /// <summary>

        /// Función para la retornar validación - función con inyección de dependencia

        /// </summary>

        /// <param name="context"></param>

        /// <returns></returns>

        public IEnumerable<ModelValidationResult> Validate(ModelValidationContext context)

        {

            return new List<ModelValidationResult>

                {

                    new ModelValidationResult("", ErrorMessage)

                };

        }

    }

}