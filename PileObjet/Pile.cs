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
        ///Une pile est vide si nbMaxElt = 0
        /// </summary>
        /// <param name="pUnePile"></param>
        /// <returns></returns>
        public bool PileVide()
        {
            return this.elements.Count == 0;
        }

        ///<summary>
        ///retourne un booléen indiquant si la pile est pleine
        ///Une pile est pleine si maxElt = pUnePile.tabElem.Count
        /// </summary>
        /// <param name="pUnePile"></param>
        /// <returns></returns>
        public bool PilePleine()
        {
            return this.nbMaxElt == this.elements.Count;
        }

        ///<summary>
        ///Cette méthode ajoute la valeur passée en paramètre au sommet de la pile
        ///SI la pile n'est pas pleine.
        ///Si la pile est pleine, déclenchement d'une exception
        /// </summary>
        /// <param name="pUnePile">pile sur laquelle il faut empiler</param>
        /// <param name="PObj">éléments à empiler</param>

        public void Empiler(int nb)
        {
            if (!PilePleine())
            {
                this.elements.Add(nb);
            }
            else
            {
                throw new System.Exception("Pile pleine, impossible d'empiler un élément");
            }
        }

        public int Depiler()
        {
            if (!PileVide())
            {
                int result = (int)this.elements[this.elements.Count - 1];
                this.elements.RemoveAt(this.elements.Count - 1);
                return result;
            }
            else
            {
                throw new System.Exception("Impossible de dépiler, pile vide");
            }
        }
    }
}
