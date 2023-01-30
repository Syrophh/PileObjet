namespace MesOutils
{
    /// <summary>
    /// Pile contenant pouvant contenir des entiers.
    /// On ajoute après le dernier élément ajouté.
    /// On retire toujours le dernier élément ajouté.
    /// </summary>
    class Pile
    {
        /// <summary>
        /// Nombre maximum d'éléments de la pile
        /// </summary>
        private int nbMaxElt;

        /// <summary>
        /// Liste contenant les éléments de la pile
        /// </summary>
        private System.Collections.Generic.List<int> elements;

        public Pile(int nbMaxElt)
        {
            this.nbMaxElt = nbMaxElt;
            this.elements = new System.Collections.Generic.List<int>();
        }


        ///<summary>
        ///retourne un booléen indiquant si la pile est vide
        ///Une pile est vide si maxElt = 0
        /// </summary>
        /// <param name="pUnePile"></param>
        /// <returns></returns>
        static bool PileVide(Pile pUnePile)
        {
            return pUnePile.elements.Count == 0;
        }

        ///<summary>
        ///retourne un booléen indiquant si la pile est pleine
        ///Une pile est pleine si maxElt = pUnePile.tabElem.Count
        /// </summary>
        /// <param name="pUnePile"></param>
        /// <returns></returns>
        static bool PilePleine(Pile pUnePile)
        {
            return pUnePile.nbMaxElt == pUnePile.elements.Count;
        }

        ///<summary>
        ///Cette méthode ajoute la valeur passée en paramètre au sommet de la pile
        ///SI la pile n'est pas pleine.
        ///Si la pile est pleine, déclenchement d'une exception
        /// </summary>
        /// <param name="pUnePile">pile sur laquelle il faut empiler</param>
        /// <param name="PObj">éléments à empiler</param>

        static void Empiler(ref Pile pUnePile, Object PObj)
        {
            if (!PilePleine(pUnePile))
            {
                pUnePile.tabElem.Add(PObj);
            }
            else
            {
                throw new Exception("Pile pleine, impossible d'empiler un élément");
            }

        }
    }
}
