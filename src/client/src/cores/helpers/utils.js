// declare const window: any;

export function showSpinner() {
  const blockUI = document.querySelector(".blockUI");
  if (blockUI) {
    const style = blockUI.getAttribute("style");
    if (style !== "display: flex;") {
      blockUI.setAttribute("style", "display: flex;");
    }
  }
}

export function hideSpinner() {
  const blockUI = document.querySelector(".blockUI");

  if (blockUI) {
    setTimeout(() => {
      blockUI.setAttribute("style", "display: none;");
    }, 300);
  }
}
