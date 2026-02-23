#!/bin/bash
# Beginner-friendly test runner script

# Colors for terminal output
GREEN='\033[0;32m'
RED='\033[0;31m'
YELLOW='\033[1;33m'
BLUE='\033[0;34m'
NC='\033[0m' # No Color

echo""
echo "======================================"
echo "  🧪 Running Tests..."
echo "======================================"
echo ""

# Determine temp directory based on OS
if [[ "$OSTYPE" == "msys" || "$OSTYPE" == "win32" || "$OSTYPE" == "cygwin" ]]; then
    # Windows (Git Bash, WSL, or Cygwin)
    TEMP_DIR="${TEMP:-$TMPDIR}"
    TEMP_DIR="${TEMP_DIR:-/c/Temp}"
else
    # macOS/Linux
    TEMP_DIR="${TMPDIR:-/tmp}"
fi

# Run dotnet test with results redirected to temp directory
TEST_OUTPUT=$(dotnet test "$@" --verbosity normal --results-directory "$TEMP_DIR/TestResults" 2>&1)
EXIT_CODE=$?

# Display the output with better formatting
PREV_LINE_TYPE=""
SHOW_ERROR_DETAILS=false
echo "$TEST_OUTPUT" | while IFS= read -r line; do
    if [[ $line =~ "Passed Test" ]]; then
        # Add spacing before test result
        if [[ -n "$PREV_LINE_TYPE" ]]; then
            echo ""
        fi
        # Extract test name and make it more readable
        TEST_NAME=$(echo "$line" | sed 's/.*Passed //' | sed 's/ \[.*//')
        TEST_NUM=$(echo "$TEST_NAME" | grep -o 'Test[0-9]*' | sed 's/Test//')
        TEST_DESC=$(echo "$TEST_NAME" | sed 's/Test[0-9]*_//' | sed 's/\([A-Z]\)/ \1/g' | sed 's/^[[:space:]]*//')
        echo -e "${GREEN}✅ TEST $TEST_NUM: $TEST_DESC${NC}"
        PREV_LINE_TYPE="test"
        SHOW_ERROR_DETAILS=false
    elif [[ $line =~ "Failed Test" ]]; then
        # Add spacing before test result
        if [[ -n "$PREV_LINE_TYPE" ]]; then
            echo ""
        fi
        TEST_NAME=$(echo "$line" | sed 's/.*Failed //' | sed 's/ \[.*//')
        TEST_NUM=$(echo "$TEST_NAME" | grep -o 'Test[0-9]*' | sed 's/Test//')
        TEST_DESC=$(echo "$TEST_NAME" | sed 's/Test[0-9]*_//' | sed 's/\([A-Z]\)/ \1/g' | sed 's/^[[:space:]]*//')
        echo -e "${RED}❌ TEST $TEST_NUM: $TEST_DESC${NC}"
        PREV_LINE_TYPE="test"
        SHOW_ERROR_DETAILS=false
    elif [[ $line =~ "Error Message:" ]]; then
        echo -e "   ${YELLOW}$line${NC}"
        PREV_LINE_TYPE="error"
        SHOW_ERROR_DETAILS=true
    elif [[ $line =~ "Stack Trace:" ]]; then
        # Stop showing error details when we hit stack trace
        SHOW_ERROR_DETAILS=false
        PREV_LINE_TYPE="stack"
    elif [[ $line =~ "💡" ]] || [[ $line =~ "Tip:" ]]; then
        echo -e "   ${BLUE}$line${NC}"
        PREV_LINE_TYPE="tip"
    elif [[ $line =~ "Test summary:" ]] || [[ $line =~ "total:" ]]; then
        echo ""
        echo "======================================"
        echo -e "${YELLOW}$line${NC}"
        PREV_LINE_TYPE="summary"
        SHOW_ERROR_DETAILS=false
    elif [[ $SHOW_ERROR_DETAILS == true ]]; then
        # Show error message content (anything after "Error Message:")
        if [[ ! $line =~ "at System\." ]] && [[ ! $line =~ "at Microsoft\." ]] && [[ ! $line =~ "at HelloGitHub" ]] && [[ ! $line =~ "at CalculatorLite" ]] && [[ ! $line =~ "at ProfileCard" ]] && [[ ! $line =~ "at GuessTheNumber" ]] && [[ ! $line =~ "at TextMenuApp" ]] && [[ ! $line =~ "at ClassRoster" ]] && [[ ! $line =~ "at MadLibs" ]] && [[ ! $line =~ "at ScoreStats" ]]; then
            # Show the error message content
            if [[ -n "$line" ]]; then
                echo "   $line"
            fi
        fi
    elif [[ ! $line =~ "Stack Trace:" ]] && [[ ! $line =~ "at System\." ]] && [[ ! $line =~ "at Microsoft\." ]] && [[ ! $line =~ "at HelloGitHub" ]] && [[ ! $line =~ "at CalculatorLite" ]] && [[ ! $line =~ "at ProfileCard" ]] && [[ ! $line =~ "at GuessTheNumber" ]] && [[ ! $line =~ "at TextMenuApp" ]] && [[ ! $line =~ "at ClassRoster" ]] && [[ ! $line =~ "at MadLibs" ]] && [[ ! $line =~ "at ScoreStats" ]] && [[ ! $line =~ "Build started" ]] && [[ ! $line =~ "Project \"" ]] && [[ ! $line =~ "Restore complete" ]]; then
        # Only show relevant error lines, skip stack traces and build noise
        if [[ $line =~ "Assert\." ]] || [[ $line =~ "Expected" ]] || [[ $line =~ "Actual" ]] || [[ $line =~ "❌" ]] || [[ $line =~ "✏️" ]]; then
            echo "   $line"
            PREV_LINE_TYPE="detail"
        fi
    fi
done

echo ""
echo "======================================"
if [ $EXIT_CODE -eq 0 ]; then
    echo -e "${GREEN}🎉 All Tests Passed!${NC}"
else
    echo -e "${YELLOW}⚠️  Some Tests Failed - See details above${NC}"
fi
echo "======================================"
echo ""

exit $EXIT_CODE
