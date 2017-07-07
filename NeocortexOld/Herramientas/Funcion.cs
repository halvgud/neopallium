using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Neocortex.Herramientas
{
    public class Funcion
    {

        public delegate object ConstructorDelegate(params object[] args);

        public static ConstructorDelegate CrearConstructor(Type type, params Type[] parameters)
        {
            var constructorInfo = type.GetConstructor(parameters);
            var paramExpr = Expression.Parameter(typeof(Object[]));

            var constructorParameters = parameters.Select((paramType, index) =>
                Expression.Convert(
                    Expression.ArrayAccess(
                        paramExpr,
                        Expression.Constant(index)),
                    paramType)).ToArray();

            var body = Expression.New(constructorInfo, constructorParameters);

            var constructor = Expression.Lambda<ConstructorDelegate>(body, paramExpr);
            return constructor.Compile();
        }
    }
}
