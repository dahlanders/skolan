# Regex 3

## Ta bort Name

Kolla i ContentType.cs.  Ta bort Name=”….” överallt mha reguljäruttryck.

T.ex 

    [Display(Name = "Tilldela aktiviteten till denna roll.", Order = 2)] 

till

    [Display(Order = 2)] 



## Ta bort Required

Kolla i ContentType.cs.  Ta bort [Required(...)] överallt.

T.ex 

        [Display(Name = "Tilldela aktiviteten till denna roll.", Order = 2)]
        [Required(AllowEmptyStrings = false)]
        [Enum(typeof(Enums.AssignedActivityRole))]

till

        [Display(Name = "Tilldela aktiviteten till denna roll.", Order = 2)]
        [Enum(typeof(Enums.AssignedActivityRole))]
