

using System.IO.Ports;
/**
* @(#) ComSerie.cs
*/
namespace Afficheur
{
	public static class ComSerie
	{
		static SerialPort PortAffichage;
		
		public static string PortChoisi
		{
			
			get
			{
				return null;
			}
			
			set
			{
			}
			
		}
		
		/**
		 * <summary>
		 * Envoie le message passé sur le port série sélectionné
		 * </summary>
		 * <param name="Message">Le message/</param>
		 * <param name="PortSerie">Le port série</param>
		 * <returns> Ok si la transmission c'est bien passée.</returns>
		 */
		public static string Envoi( string Message )
		{
			return null;
		}
		
	}
	
}
