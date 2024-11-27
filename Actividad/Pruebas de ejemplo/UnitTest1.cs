namespace Pruebas_de_ejemplo
{

    public class OperacionesAritm�ticas
    {
        public int Suma(int numeroUno, int numeroDos)
        {
            return numeroUno + numeroDos;
        }

        public int Resta(int numeroUno, int numeroDos)
        {
            return numeroUno - numeroDos;   
        }
    }

    public class UnitTest1
    {

        private OperacionesAritm�ticas _operaciones = new OperacionesAritm�ticas();

        [Fact]
        public void SumaDeNumerosTest()
        {
            int numUno = 12;
            int numeroDos = 12;
            int resultadoObtenido = _operaciones.Suma(numeroDos, numUno);
            int resultadoEsperado = 24;
            Assert.Equal(resultadoObtenido, resultadoEsperado);
        }

        [Fact]
        public void RestaDeNumerosTest()
        {
            int numUno = 12;
            int numeroDos = 12;
            int resultadoObtenido = _operaciones.Resta(numeroDos, numUno);
            int resultadoEsperado = 0;
            Assert.Equal(resultadoObtenido, resultadoEsperado);
        }
    }
}