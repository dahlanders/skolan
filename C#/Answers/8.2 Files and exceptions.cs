private static bool CreateTextHandleExceptionDetail(string filename)
{
    ConsoleHelper ch = new ConsoleHelper();
    try
    {
        File.CreateText(filename);
        Console.WriteLine($"The file '{filename}' is now created");
        return true;
    }
    catch (UnauthorizedAccessException)
    {
        ch.ErrorMessage("You're not authorized to create this file");
    }
    catch (DirectoryNotFoundException)
    {
        ch.ErrorMessage("Directory not found");
    }
    catch (IOException)
    {
        ch.ErrorMessage("Input output exception");
    }
    catch (ArgumentException)
    {
        ch.ErrorMessage("The filename is not valid");
    }
    catch (Exception)
    {
        ch.ErrorMessage($"Something strange happened");
    }
    return false;
}
